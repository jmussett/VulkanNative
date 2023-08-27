using System.Runtime.InteropServices;

namespace VulkanNative.Examples.HelloTriangle;

public unsafe class VulkanInstance
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
}

public class DebugUtils
{
    private VkInstance _handle;
    private VkExtDebugUtilsExtension _extension;

    public DebugUtils(VkInstance handle, VkExtDebugUtilsExtension extension)
    {
        _handle = handle;
        _extension = extension;
    }

    public unsafe DebugMessenger CreateMessenger()
    {
        var messenger = new VkDebugUtilsMessengerEXT();

        var debugMessenger = new DebugMessenger(messenger);

        var userCallback = (delegate* unmanaged[Cdecl]<VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void*, void>)
            Marshal.GetFunctionPointerForDelegate(debugMessenger.DebugCallback);

        var createInfo = new VkDebugUtilsMessengerCreateInfoEXT
        {
            SType = (VkStructureType)1000128004, //FIX: VkStructureType.VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT,
            MessageSeverity = VkDebugUtilsMessageSeverityFlagsEXT.VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT | VkDebugUtilsMessageSeverityFlagsEXT.VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT | VkDebugUtilsMessageSeverityFlagsEXT.VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT | VkDebugUtilsMessageSeverityFlagsEXT.VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT,
            MessageType = VkDebugUtilsMessageTypeFlagsEXT.VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT | VkDebugUtilsMessageTypeFlagsEXT.VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT | VkDebugUtilsMessageTypeFlagsEXT.VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT | VkDebugUtilsMessageTypeFlagsEXT.VK_DEBUG_UTILS_MESSAGE_TYPE_DEVICE_ADDRESS_BINDING_BIT_EXT,
            PfnUserCallback = userCallback
        };

        _extension.VkCreateDebugUtilsMessengerEXT(_handle, &createInfo, null, &messenger).ThrowOnError();

        return debugMessenger;
    }

    public class DebugMessenger
    {
        private readonly VkDebugUtilsMessengerEXT _handle;

        public DebugMessenger(VkDebugUtilsMessengerEXT handle)
        {
            _handle = handle;
        }

        public event Action<string>? OnMessage;

        public unsafe uint DebugCallback
        (
            VkDebugUtilsMessageSeverityFlagsEXT messageSeverity,
            VkDebugUtilsMessageTypeFlagsEXT messageTypes,
            VkDebugUtilsMessengerCallbackDataEXT* pCallbackData,
            void* pUserData
        )
        {
            OnMessage?.Invoke(Marshal.PtrToStringAnsi((nint)pCallbackData->PMessage)!);

            return 0;
        }

    }

}
