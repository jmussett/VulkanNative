using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkGlobalCommands
{
    private delegate* unmanaged[Cdecl]<VkInstanceCreateInfo*, VkAllocationCallbacks*, VkInstance*, VkResult> _vkCreateInstance;
    private delegate* unmanaged[Cdecl]<char*, uint*, VkExtensionProperties*, VkResult> _vkEnumerateInstanceExtensionProperties;
    private delegate* unmanaged[Cdecl]<uint*, VkLayerProperties*, VkResult> _vkEnumerateInstanceLayerProperties;
    private delegate* unmanaged[Cdecl]<uint*, VkResult> _vkEnumerateInstanceVersion;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateInstance(VkInstanceCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkInstance* pInstance)
    {
        return _vkCreateInstance(pCreateInfo, pAllocator, pInstance);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkEnumerateInstanceExtensionProperties(char* pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties)
    {
        return _vkEnumerateInstanceExtensionProperties(pLayerName, pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkEnumerateInstanceLayerProperties(uint* pPropertyCount, VkLayerProperties* pProperties)
    {
        return _vkEnumerateInstanceLayerProperties(pPropertyCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkEnumerateInstanceVersion(uint* pApiVersion)
    {
        return _vkEnumerateInstanceVersion(pApiVersion);
    }
}