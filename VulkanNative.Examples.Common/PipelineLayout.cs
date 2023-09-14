using System;

namespace VulkanNative.Examples.Common;

public sealed unsafe class PipelineLayout : IDisposable
{
    private VkPipelineLayout _handle;

    private readonly VkDevice _deviceHandle;
    private readonly VkDeviceCommands _commands;

    public nint Handle => _handle;

    public PipelineLayout(VkPipelineLayout handle, VkDevice deviceHandle, VkDeviceCommands commands)
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

        _commands.vkDestroyPipelineLayout(_deviceHandle, _handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~PipelineLayout()
    {
        Dispose();
    }
}
