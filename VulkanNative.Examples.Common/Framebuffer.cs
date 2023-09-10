namespace VulkanNative.Examples.Common;

public unsafe class Framebuffer : IDisposable
{
    private VkFramebuffer _handle;
    private readonly VkDevice _deviceHandle;
    private readonly VkDeviceCommands _commands;

    public Framebuffer(VkFramebuffer handle, VkDevice deviceHandle, VkDeviceCommands commands)
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

        _commands.vkDestroyFramebuffer(_deviceHandle, _handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~Framebuffer()
    {
        Dispose();
    }
}
