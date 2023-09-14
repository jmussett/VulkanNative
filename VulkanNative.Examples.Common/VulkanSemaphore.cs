using System;

namespace VulkanNative.Examples.Common;

public unsafe sealed class VulkanSemaphore : IDisposable
{
    private VkSemaphore _handle;
    private VkDevice _deviceHandle;
    private readonly VkDeviceCommands _commands;
    public nint Handle => _handle;

    public VulkanSemaphore(VkSemaphore handle, VkDevice deviceHandle, VkDeviceCommands commands)
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

        _commands.vkDestroySemaphore(_deviceHandle, _handle, null);
        _deviceHandle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~VulkanSemaphore()
    {
        Dispose();
    }
}
