namespace VulkanNative.Examples.Common;

public sealed unsafe class RenderPass : IDisposable
{
    private VkRenderPass _handle;
    private readonly VkDevice _deviceHandle;
    private readonly VkDeviceCommands _commands;

    public RenderPass(VkRenderPass handle, VkDevice deviceHandle, VkDeviceCommands commands)
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

        _commands.vkDestroyRenderPass(_deviceHandle, _handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~RenderPass()
    {
        Dispose();
    }
}
