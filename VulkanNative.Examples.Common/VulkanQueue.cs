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

    public void Submit(CommandSubmission submission, VulkanFence? fence = null)
    {
        var queueSubmitInfoPtr = stackalloc VkSubmitInfo[1];

        using UnmanagedBuffer<VkSemaphore> waitSemaphoreBuffer = new();
        using UnmanagedBuffer<VkSemaphore> signalSemaphoreBuffer = new();
        using UnmanagedBuffer<VkCommandBuffer> commandBuffersBuffer = new();
        using UnmanagedBuffer<VkPipelineStageFlags> waitStagesBuffer = new();

        for (var j = 0; j < submission.WaitSemaphores.Count; j++)
        {
            waitSemaphoreBuffer.Add(submission.WaitSemaphores[j].Handle);
        }

        for (var j = 0; j < submission.SignalSemaphores.Count; j++)
        {
            signalSemaphoreBuffer.Add(submission.SignalSemaphores[j].Handle);
        }

        for (var j = 0; j < submission.CommandBuffers.Count; j++)
        {
            commandBuffersBuffer.Add(submission.CommandBuffers[j].Handle);
        }

        for (var j = 0; j < submission.WaitStages.Count; j++)
        {
            waitStagesBuffer.Add(submission.WaitStages[j]);
        }

        queueSubmitInfoPtr[0] = new()
        {
            waitSemaphoreCount = (uint)waitSemaphoreBuffer.Length,
            pWaitSemaphores = waitSemaphoreBuffer.AsPointer(),
            signalSemaphoreCount = (uint)signalSemaphoreBuffer.Length,
            pSignalSemaphores = signalSemaphoreBuffer.AsPointer(),
            commandBufferCount = (uint)commandBuffersBuffer.Length,
            pCommandBuffers = commandBuffersBuffer.AsPointer(),
            // TODO: assert against wait semaphores
            pWaitDstStageMask = waitStagesBuffer.AsPointer()
        };

        _commands.vkQueueSubmit(_handle, 1, queueSubmitInfoPtr, fence?.Handle ?? nint.Zero)
            .ThrowOnError();
    }

    public void Submit(Span<CommandSubmission> submission, VulkanFence? fence = null)
    {
        var queueSubmitInfoPtr = stackalloc VkSubmitInfo[submission.Length];

        using UnmanagedJaggedArray<VkSemaphore> waitSemaphores = new();
        using UnmanagedJaggedArray<VkSemaphore> signalSemaphores = new();
        using UnmanagedJaggedArray<VkCommandBuffer> commandBuffers = new();
        using UnmanagedJaggedArray<VkPipelineStageFlags> waitStages = new();

        for (var i = 0; i < submission.Length; i++)
        {
            UnmanagedBuffer<VkSemaphore> waitSemaphoreBuffer = new();
            UnmanagedBuffer<VkSemaphore> signalSemaphoreBuffer = new();
            UnmanagedBuffer<VkCommandBuffer> commandBuffersBuffer = new();
            UnmanagedBuffer<VkPipelineStageFlags> waitStagesBuffer = new();

            for (var j = 0; j < submission[i].WaitSemaphores.Count; j++)
            {
                waitSemaphoreBuffer.Add(submission[i].WaitSemaphores[j].Handle);
            }

            for (var j = 0; j < submission[i].SignalSemaphores.Count; j++)
            {
                signalSemaphoreBuffer.Add(submission[i].SignalSemaphores[j].Handle);
            }

            for (var j = 0; j < submission[i].CommandBuffers.Count; j++)
            {
                commandBuffersBuffer.Add(submission[i].CommandBuffers[j].Handle);
            }

            for (var j = 0; j < submission[i].WaitStages.Count; j++)
            {
                waitStagesBuffer.Add(submission[i].WaitStages[j]);
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
                pWaitDstStageMask = waitStagesBuffer.AsPointer()
            };

            waitSemaphores.Add(waitSemaphoreBuffer);
            signalSemaphores.Add(signalSemaphoreBuffer);
            commandBuffers.Add(commandBuffersBuffer);
            waitStages.Add(waitStagesBuffer);
        }

        _commands.vkQueueSubmit(_handle, (uint)submission.Length, queueSubmitInfoPtr, fence?.Handle ?? nint.Zero)
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

    public void WaitIdle()
    {
        _commands.vkQueueWaitIdle(_handle).ThrowOnError();
    }
}
