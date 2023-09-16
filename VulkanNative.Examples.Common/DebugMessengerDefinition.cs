using System;
using System.Runtime.InteropServices;

namespace VulkanNative.Examples.Common;

public sealed unsafe class DebugMessengerDefinition : IExtensionChain<InstanceDefinition>, IDisposable
{
    private readonly GCHandle _gcHandle;

    private VkDebugUtilsMessengerCreateInfoEXT _chainHandle;

    public nint ChainHandle
    {
        get
        {
            fixed (VkDebugUtilsMessengerCreateInfoEXT* chainHandlePtr = &_chainHandle)
                return new nint(chainHandlePtr);
        }
    }

    public event Action<string>? OnMessage;

    public DebugMessengerDefinition(VkDebugUtilsMessageSeverityFlagsEXT severity, VkDebugUtilsMessageTypeFlagsEXT messageType)
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

    ~DebugMessengerDefinition()
    {
        Dispose(false);
    }
}
