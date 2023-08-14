namespace VulkanNative;

public unsafe class VkNvxBinaryImportExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkCuModuleCreateInfoNVX*, VkAllocationCallbacks*, VkCuModuleNVX*, VkResult> vkCreateCuModuleNVX;
    public delegate* unmanaged[Cdecl]<VkDevice, VkCuFunctionCreateInfoNVX*, VkAllocationCallbacks*, VkCuFunctionNVX*, VkResult> vkCreateCuFunctionNVX;
    public delegate* unmanaged[Cdecl]<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void> vkDestroyCuModuleNVX;
    public delegate* unmanaged[Cdecl]<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void> vkDestroyCuFunctionNVX;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCuLaunchInfoNVX*, void> vkCmdCuLaunchKernelNVX;
}