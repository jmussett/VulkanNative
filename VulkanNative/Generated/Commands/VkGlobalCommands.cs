using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkGlobalCommands
{
    private delegate* unmanaged[Cdecl]<VkInstanceCreateInfo*, VkAllocationCallbacks*, VkInstance*, VkResult> _vkCreateInstance;
    private delegate* unmanaged[Cdecl]<byte*, uint*, VkExtensionProperties*, VkResult> _vkEnumerateInstanceExtensionProperties;
    private delegate* unmanaged[Cdecl]<uint*, VkLayerProperties*, VkResult> _vkEnumerateInstanceLayerProperties;
    private delegate* unmanaged[Cdecl]<uint*, VkResult> _vkEnumerateInstanceVersion;

    public VkGlobalCommands(IFunctionLoader loader)
    {
        _vkCreateInstance = (delegate* unmanaged[Cdecl]<VkInstanceCreateInfo*, VkAllocationCallbacks*, VkInstance*, VkResult>)loader.GetProcAddr("vkCreateInstance");
        _vkEnumerateInstanceExtensionProperties = (delegate* unmanaged[Cdecl]<byte*, uint*, VkExtensionProperties*, VkResult>)loader.GetProcAddr("vkEnumerateInstanceExtensionProperties");
        _vkEnumerateInstanceLayerProperties = (delegate* unmanaged[Cdecl]<uint*, VkLayerProperties*, VkResult>)loader.GetProcAddr("vkEnumerateInstanceLayerProperties");
        _vkEnumerateInstanceVersion = (delegate* unmanaged[Cdecl]<uint*, VkResult>)loader.GetProcAddr("vkEnumerateInstanceVersion");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCreateInstance(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance)
    {
        return _vkCreateInstance(pCreateInfo, pAllocator, pInstance);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkEnumerateInstanceExtensionProperties(byte* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
    {
        return _vkEnumerateInstanceExtensionProperties(pLayerName, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkEnumerateInstanceLayerProperties(uint* pPropertyCount, VkLayerProperties* pProperties)
    {
        return _vkEnumerateInstanceLayerProperties(pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkEnumerateInstanceVersion(uint* pApiVersion)
    {
        return _vkEnumerateInstanceVersion(pApiVersion);
    }
}