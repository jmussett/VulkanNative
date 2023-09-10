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
}