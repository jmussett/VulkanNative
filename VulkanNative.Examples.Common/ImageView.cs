using System;

namespace VulkanNative.Examples.Common;

public sealed unsafe class ImageView : IDisposable
{
    private VkImageView _handle;
    private readonly VkDevice _deviceHandle;
    private readonly VkDeviceCommands _commands;

    public nint Handle => _handle;

    public ImageView(VkImageView handle, VkDevice deviceHandle, VkDeviceCommands commands)
    {
        _handle = handle;
        _deviceHandle = deviceHandle;
        _commands = commands;
    }

    public void Dispose()
    {
        if (_handle == nint.Zero)
        {
            return;
        }

        _commands.vkDestroyImageView(_deviceHandle, _handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~ImageView()
    {
        Dispose();
    }
}
