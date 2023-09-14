using System;
using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public unsafe sealed class CommandBuffer
{
    private readonly VkCommandBuffer _handle;
    private readonly VkDeviceCommands _commands;

    public nint Handle => _handle;

    public CommandBuffer(VkCommandBuffer handle, VkDeviceCommands commands)
    {
        _handle = handle;
        _commands = commands;
    }

    public void Begin(VkCommandBufferUsageFlags flags = 0)
    {
        VkCommandBufferBeginInfo beginInfo = new()
        {
            flags = flags, // TODO: None
            pInheritanceInfo = null, // TODO,
            pNext = null // TODO
        };

        _commands.vkBeginCommandBuffer(_handle, &beginInfo).ThrowOnError();
    }

    public void End()
    {
        _commands.vkEndCommandBuffer(_handle).ThrowOnError();
    }

    public void BeginRenderPass(Framebuffer framebuffer, RenderPass renderPass, ReadOnlySpan<ClearValue> clearValues, VkRect2D area, VkSubpassContents contents)
    {
        fixed(ClearValue* clearValuePtr = clearValues)
        {
            VkRenderPassBeginInfo beginInfo = new()
            {
                clearValueCount = (uint)clearValues.Length,
                // Both ClearValue and VkClearValue have the same struct layout so they can be cast.
                pClearValues = (VkClearValue*) clearValuePtr,
                framebuffer = framebuffer.Handle,
                renderPass = renderPass.Handle,
                renderArea = area
            };

            _commands.vkCmdBeginRenderPass(_handle, &beginInfo, contents);
        }
    }

    public void EndRenderPass()
    {
        _commands.vkCmdEndRenderPass(_handle);
    }

    public void BindPipeline(VkPipelineBindPoint bindPoint, Pipeline pipeline)
    {
        _commands.vkCmdBindPipeline(_handle, bindPoint, pipeline.Handle);
    }

    public void SetViewport(uint firstViewport, ReadOnlySpan<VkViewport> viewports)
    {
        fixed(VkViewport* viewportPtr = viewports)
            _commands.vkCmdSetViewport(_handle, firstViewport, (uint)viewports.Length, viewportPtr);
    }

    public void SetScissor(uint firstScissor, ReadOnlySpan<VkRect2D> scissors)
    {
        fixed (VkRect2D* scissorsPtr = scissors)
            _commands.vkCmdSetScissor(_handle, firstScissor, (uint) scissors.Length, scissorsPtr);
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