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
}