using System.Runtime.InteropServices;
using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed unsafe class DebugMessenger : IDisposable
{
    private readonly VkInstance _instanceHandle;
    private readonly VkDebugUtilsMessengerEXT _messengerHandle;
    private readonly VkExtDebugUtilsExtension _extension;
    private readonly GCHandle _gcHandle;

    public DebugMessenger(VkInstance instanceHandle, VkExtDebugUtilsExtension extension, VkDebugUtilsMessageSeverityFlagsEXT severity, VkDebugUtilsMessageTypeFlagsEXT messageType)
    {
        _instanceHandle = instanceHandle;
        _extension = extension;

        var callbackHandle = Marshal.GetFunctionPointerForDelegate(DebugCallback);

        var createInfo = new VkDebugUtilsMessengerCreateInfoEXT
        {
            SType = (VkStructureType)1000128004, //FIX: VkStructureType.VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT,
            MessageSeverity = severity,
            MessageType = messageType,
            PfnUserCallback = (delegate* unmanaged[Cdecl]<VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void*, void>) callbackHandle
        };

        VkDebugUtilsMessengerEXT messengerHandle;

        _extension.VkCreateDebugUtilsMessengerEXT(_instanceHandle, &createInfo, null, &messengerHandle).ThrowOnError();

        _messengerHandle = messengerHandle;

        _gcHandle = GCHandle.Alloc(callbackHandle);
    }

    public event Action<string>? OnMessage;

    private unsafe uint DebugCallback
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

    public void Dispose()
    {
        _extension.VkDestroyDebugUtilsMessengerEXT(_instanceHandle, _messengerHandle, null);

        _gcHandle.Free();
    }
}