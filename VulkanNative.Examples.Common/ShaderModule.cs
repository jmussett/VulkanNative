using System;

namespace VulkanNative.Examples.Common;

public sealed unsafe class ShaderModule : IDisposable
{
    private VkShaderModule _handle;
    private readonly VkDevice _deviceHandle;
    private readonly VkDeviceCommands _commands;

    public nint Handle => _handle;

    public ShaderModule(VkShaderModule handle, VkDevice deviceHandle, VkDeviceCommands commands)
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

        _commands.vkDestroyShaderModule(_deviceHandle, _handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~ShaderModule()
    {
        Dispose();
    }
}