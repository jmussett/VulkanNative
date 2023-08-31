using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed unsafe class VulkanInstance : IDisposable
{
    private VkInstance _handle;

    private readonly VulkanLoader _loader;
    private readonly VkInstanceCommands _commands;

    private VkKhrSurfaceExtension? _surfaceExtension;

    public nint Handle => _handle;

    public VulkanInstance(VkInstance handle, VulkanLoader loader)
    {
        _handle = handle;
        _loader = loader;
        _commands = loader.LoadInstanceCommands(handle);
    }

    public PhysicalDevice[] GetPhysicalDevices()
    {
        uint count;

        _commands.vkEnumeratePhysicalDevices(_handle, &count, (VkPhysicalDevice*)null).ThrowOnError();

        var physicalDevicesPtr = stackalloc VkPhysicalDevice[(int)count];

        _commands.vkEnumeratePhysicalDevices(_handle, &count, physicalDevicesPtr).ThrowOnError();

        var physicalDevices = new PhysicalDevice[count];

        for(var i = 0; i < count; i++)
        {
            physicalDevices[i] = new PhysicalDevice(physicalDevicesPtr[i], _loader, _commands);
        }

        return physicalDevices;
    }

    public VulkanSurface LoadSurface(nint surfaceHandle)
    {
        _surfaceExtension ??= _loader.Extensions.LoadVkKhrSurfaceExtension(_handle);

        return new VulkanSurface(surfaceHandle, _handle, _surfaceExtension);
    }

    public DebugUtils LoadDebugUtilsExtension()
    {
        var extension = _loader.Extensions.LoadVkExtDebugUtilsExtension(_handle);

        return new DebugUtils(_handle, extension);
    }

    public void Dispose()
    {
        if (_handle == nint.Zero)
        {
            return;
        }

        _commands.vkDestroyInstance(_handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~VulkanInstance()
    {
        Dispose();
    }
}