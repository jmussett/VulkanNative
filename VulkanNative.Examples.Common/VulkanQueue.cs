using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public unsafe class VulkanQueue
{
    private readonly VkQueue _handle;
    private readonly VkDeviceCommands _commands;
    private readonly VkKhrSwapchainExtension _swapchainExtension;

    public VulkanQueue(VkQueue handle, VkDeviceCommands commands, VkKhrSwapchainExtension swapchainExtension)
    {
        _handle = handle;
        _commands = commands;
        _swapchainExtension = swapchainExtension;
    }

    public void Submit(Span<QueueSubmission> queueSubmissions, VulkanFence? fence = null)
    {
        var queueSubmitInfoPtr = stackalloc VkSubmitInfo[queueSubmissions.Length];

        using UnmanagedJaggedArray<VkSemaphore> waitSemaphores = new();
        using UnmanagedJaggedArray<VkSemaphore> signalSemaphores = new();
        using UnmanagedJaggedArray<VkCommandBuffer> commandBuffers = new();

        for (var i = 0; i < queueSubmissions.Length; i++)
        {
            UnmanagedBuffer<VkSemaphore> waitSemaphoreBuffer = new();
            UnmanagedBuffer<VkSemaphore> signalSemaphoreBuffer = new();
            UnmanagedBuffer<VkCommandBuffer> commandBuffersBuffer = new();

            for (var j = 0; j < queueSubmissions[i].WaitSemaphores.Length; j++)
            {
                waitSemaphoreBuffer.Add(queueSubmissions[i].WaitSemaphores[j].Handle);
            }

            for (var j = 0; j < queueSubmissions[i].SignalSemaphores.Length; j++)
            {
                signalSemaphoreBuffer.Add(queueSubmissions[i].SignalSemaphores[j].Handle);
            }

            for (var j = 0; j < queueSubmissions[i].CommandBuffers.Length; j++)
            {
                commandBuffersBuffer.Add(queueSubmissions[i].CommandBuffers[j].Handle);
            }

            queueSubmitInfoPtr[i] = new()
            {
                waitSemaphoreCount = (uint)waitSemaphoreBuffer.Length,
                pWaitSemaphores = waitSemaphoreBuffer.AsPointer(),
                signalSemaphoreCount = (uint)signalSemaphoreBuffer.Length,
                pSignalSemaphores = signalSemaphoreBuffer.AsPointer(),
                commandBufferCount = (uint) commandBuffersBuffer.Length,
                pCommandBuffers = commandBuffersBuffer.AsPointer(),
                // TODO: assert against wait semaphores
                pWaitDstStageMask = queueSubmissions[i].WaitStages.AsPointer()
            };

            waitSemaphores.Add(waitSemaphoreBuffer);
            signalSemaphores.Add(signalSemaphoreBuffer);
            commandBuffers.Add(commandBuffersBuffer);
        }

        _commands.vkQueueSubmit(_handle, (uint)queueSubmissions.Length, queueSubmitInfoPtr, fence?.Handle ?? nint.Zero)
            .ThrowOnError();
    }

    public QueuePresentResult Present(Span<VulkanSwapchain> swapchains, Span<VulkanSemaphore> waitSemaphores, Span<uint> imageIndexes)
    {
        VkSwapchainKHR* vkSwapchains = stackalloc VkSwapchainKHR[swapchains.Length];

        for(var i = 0; i < swapchains.Length; i++)
        {
            vkSwapchains[i] = swapchains[i].Handle;
        }

        VkSemaphore* vkWaitSemaphores = stackalloc VkSemaphore[waitSemaphores.Length];

        for (var i = 0; i < waitSemaphores.Length; i++)
        {
            vkWaitSemaphores[i] = waitSemaphores[i].Handle;
        }

        fixed(uint* imageIndexesPtr = imageIndexes)
        {
            VkPresentInfoKHR vkPresentInfo = new()
            {
                pSwapchains = vkSwapchains,
                swapchainCount = (uint)swapchains.Length,
                waitSemaphoreCount = (uint)waitSemaphores.Length,
                pWaitSemaphores = vkWaitSemaphores,
                pImageIndices = imageIndexesPtr,
                pResults = null // todo
            };

            var result = _swapchainExtension.vkQueuePresentKHR(_handle, &vkPresentInfo);

            return result switch
            {
                VkResult.VK_SUCCESS => QueuePresentResult.Success,
                VkResult.VK_SUBOPTIMAL_KHR => QueuePresentResult.Suboptimal,
                VkResult.VK_ERROR_OUT_OF_DATE_KHR => QueuePresentResult.OutOfDate,
                _ => throw new InvalidOperationException($"Vulkan Error: {result}")
            };
        }
    }
}
