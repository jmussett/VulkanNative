using System.Globalization;
using System.Reflection.Metadata;
using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public unsafe sealed class CommandBuffer
{
    private VkCommandBuffer _handle;
    private readonly VkDeviceCommands _commands;

    public nint Handle => _handle;

    public CommandBuffer(VkCommandBuffer handle, VkDeviceCommands commands)
    {
        _handle = handle;
        _commands = commands;
    }

    public void Begin()
    {
        VkCommandBufferBeginInfo beginInfo = new()
        {
            flags = 0, // TODO + Create None enumeration
            pInheritanceInfo = null, // TODO,
            pNext = null // TODO
        };

        _commands.vkBeginCommandBuffer(_handle, &beginInfo).ThrowOnError();
    }

    public void End()
    {
        _commands.vkEndCommandBuffer(_handle).ThrowOnError();
    }

    public void BeginRenderPass(Framebuffer framebuffer, RenderPass renderPass, VulkanBuffer<ClearValue> clearValues, VkRect2D area, VkSubpassContents contents)
    {
        VkRenderPassBeginInfo beginInfo = new()
        {
            clearValueCount = (uint) clearValues.Length,
            // Both ClearValue and VkClearValue have the same struct layout so they can be cast.
            pClearValues = (VkClearValue*) clearValues.AsPointer(),
            framebuffer = framebuffer.Handle,
            renderPass = renderPass.Handle,
            renderArea = area
        };

        _commands.vkCmdBeginRenderPass(_handle, &beginInfo, contents);
    }

    public void EndRenderPass()
    {
        _commands.vkCmdEndRenderPass(_handle);
    }

    public void BindPipeline(VkPipelineBindPoint bindPoint, Pipeline pipeline)
    {
        _commands.vkCmdBindPipeline(_handle, bindPoint, pipeline.Handle);
    }

    public void SetViewport(uint firstViewport, VulkanBuffer<VkViewport> viewports)
    {
        _commands.vkCmdSetViewport(_handle, firstViewport, (uint)viewports.Length, viewports.AsPointer());
    }

    public void SetScissor(uint firstScissor, VulkanBuffer<VkRect2D> scissors)
    {
        _commands.vkCmdSetScissor(_handle, firstScissor, (uint) scissors.Length, scissors.AsPointer());
    }

    public void Draw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
    {
        _commands.vkCmdDraw(_handle, vertexCount, instanceCount, firstVertex, firstInstance);
    }

    public void Reset(VkCommandBufferResetFlags flags = 0) // TODO: None
    {
        _commands.vkResetCommandBuffer(_handle, flags).ThrowOnError();
    }

    
}