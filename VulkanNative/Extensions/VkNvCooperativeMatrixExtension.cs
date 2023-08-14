namespace VulkanNative;

public unsafe class VkNvCooperativeMatrixExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;
}