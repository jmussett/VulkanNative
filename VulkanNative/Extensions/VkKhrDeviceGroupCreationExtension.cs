namespace VulkanNative;

public unsafe class VkKhrDeviceGroupCreationExtension
{
    public delegate* unmanaged[Cdecl]<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult> vkEnumeratePhysicalDeviceGroups;
}