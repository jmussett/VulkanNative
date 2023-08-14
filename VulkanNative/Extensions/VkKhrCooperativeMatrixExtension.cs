namespace VulkanNative;

public unsafe class VkKhrCooperativeMatrixExtension
{
    public delegate* unmanaged[Cdecl]<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesKHR*, VkResult> vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR;
}