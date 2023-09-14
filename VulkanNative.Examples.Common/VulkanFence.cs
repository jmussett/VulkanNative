using System;

namespace VulkanNative.Examples.Common;

public sealed unsafe class VulkanFence : IDisposable
{
    private VkFence _handle;
    private readonly VkDevice _deviceHandle;
    private readonly VkDeviceCommands _commands;
    public nint Handle => _handle;

    public VulkanFence(VkFence handle, VkDevice deviceHandle, VkDeviceCommands commands)
    {
        _handle = handle;
        _deviceHandle = deviceHandle;
        _commands = commands;
    }

    public void Dispose()
    {
        if (_deviceHandle == nint.Zero)
        {
            return;
        }

        _commands.vkDestroyFence(_deviceHandle, _handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~VulkanFence()
    {
        Dispose();
    }
}
