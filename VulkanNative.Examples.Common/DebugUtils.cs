namespace VulkanNative.Examples.Common;

public class DebugUtils
{
    private readonly VkInstance _handle;
    private readonly VkExtDebugUtilsExtension _extension;

    public DebugUtils(VkInstance handle, VkExtDebugUtilsExtension extension)
    {
        _handle = handle;
        _extension = extension;
    }

    public unsafe DebugMessenger CreateMessenger(VkDebugUtilsMessageSeverityFlagsEXT severity, VkDebugUtilsMessageTypeFlagsEXT messageType)
    {
        return new DebugMessenger(_handle, _extension, severity, messageType);
    }
}
