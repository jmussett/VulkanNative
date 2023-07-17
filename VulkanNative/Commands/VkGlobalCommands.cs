namespace VulkanNative;

public unsafe class VkGlobalCommands
{
    public delegate* unmanaged[Cdecl]<VkInstanceCreateInfo*, VkAllocationCallbacks*, VkInstance*, VkResult> vkCreateInstance;
    public delegate* unmanaged[Cdecl]<VkInstance, char*, PFN_vkVoidFunction> vkGetInstanceProcAddr;
    public delegate* unmanaged[Cdecl]<VkDevice, char*, PFN_vkVoidFunction> vkGetDeviceProcAddr;
    public delegate* unmanaged[Cdecl]<char*, uint*, VkExtensionProperties*, VkResult> vkEnumerateInstanceExtensionProperties;
    public delegate* unmanaged[Cdecl]<uint*, VkLayerProperties*, VkResult> vkEnumerateInstanceLayerProperties;
    public delegate* unmanaged[Cdecl]<uint*, VkResult> vkEnumerateInstanceVersion;
}