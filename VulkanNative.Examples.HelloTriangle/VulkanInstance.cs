namespace VulkanNative.Examples.HelloTriangle;

public unsafe class VulkanInstance : IDisposable
{
    private readonly VkInstance _handle;
    private readonly VulkanLoader _loader;
    private readonly VkInstanceCommands _commands;

    public VulkanInstance(VkInstance handle, VulkanLoader loader)
    {
        _handle = handle;
        _loader = loader;
        _commands = loader.LoadInstanceCommands(handle);
    }

    public UnmanagedBuffer<VkPhysicalDevice> GetPhysicalDevices()
    {
        uint count;
        _commands.VkEnumeratePhysicalDevices(_handle, &count, (VkPhysicalDevice*)null).ThrowOnError();

        UnmanagedBuffer<VkPhysicalDevice> physicalDevices = new((int)count);

        _commands.VkEnumeratePhysicalDevices(_handle, &count, physicalDevices.AsPointer()).ThrowOnError();

        return physicalDevices;
    }

    public DebugUtils LoadDebugUtils()
    {
        var extension = _loader.Extensions.LoadVkExtDebugUtilsExtension(_handle);

        return new DebugUtils(_handle, extension);
    }

    public void Dispose()
    {
        _commands.VkDestroyInstance(_handle, null);
    }
}
