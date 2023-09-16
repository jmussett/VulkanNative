using System;
using System.Runtime.InteropServices;
using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed unsafe class DebugMessenger : IExtensionChain<InstanceDefinition>, IDisposable
{
    private readonly VkInstance? _instanceHandle;
    private readonly VkExtDebugUtilsExtension? _extension;
    private readonly GCHandle _gcHandle;

    private VkDebugUtilsMessengerCreateInfoEXT _chainHandle;
    private VkDebugUtilsMessengerEXT? _handle;

    public nint ChainHandle
    {
        get
        {
            fixed (VkDebugUtilsMessengerCreateInfoEXT* chainHandlePtr = &_chainHandle)
                return new nint(chainHandlePtr);
        }
    }

    public DebugMessenger(VkDebugUtilsMessageSeverityFlagsEXT severity, VkDebugUtilsMessageTypeFlagsEXT messageType)
    {
        var callbackHandle = Marshal.GetFunctionPointerForDelegate(DebugCallback);

        _chainHandle = new VkDebugUtilsMessengerCreateInfoEXT
        {
            messageSeverity = severity,
            messageType = messageType,
            pfnUserCallback = (delegate* unmanaged[Cdecl]<VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void*, void>)callbackHandle
        };

        _gcHandle = GCHandle.Alloc(callbackHandle);
    }

    public DebugMessenger(VkInstance instanceHandle, VkExtDebugUtilsExtension extension, VkDebugUtilsMessageSeverityFlagsEXT severity, VkDebugUtilsMessageTypeFlagsEXT messageType)
    {
        _instanceHandle = instanceHandle;
        _extension = extension;

        var callbackHandle = Marshal.GetFunctionPointerForDelegate(DebugCallback);

        _chainHandle = new VkDebugUtilsMessengerCreateInfoEXT
        {
            messageSeverity = severity,
            messageType = messageType,
            pfnUserCallback = (delegate* unmanaged[Cdecl]<VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void*, void>) callbackHandle
        };

        VkDebugUtilsMessengerEXT messengerHandle;

        _extension.vkCreateDebugUtilsMessengerEXT(_instanceHandle.Value, (VkDebugUtilsMessengerCreateInfoEXT*) ChainHandle, null, &messengerHandle).ThrowOnError();

        _handle = messengerHandle;

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
        OnMessage?.Invoke(Marshal.PtrToStringAnsi((nint)pCallbackData->pMessage)!);

        return 0;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public void Dispose(bool disposing)
    {
        if (_handle is not null)
        {
            _extension!.vkDestroyDebugUtilsMessengerEXT(_instanceHandle!.Value, _handle!.Value, null);
            _handle = nint.Zero;
        }

        if (disposing)
        {
            _gcHandle.Free();
        }
    }

    public IExtensionChain<InstanceDefinition> Extend(IExtensionChain<InstanceDefinition> chain)
    {
        _chainHandle.pNext = (void*) chain.ChainHandle;

        return chain;
    }

    ~DebugMessenger()
    {
        Dispose(false);
    }
}