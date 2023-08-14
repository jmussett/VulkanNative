namespace VulkanNative;

public unsafe class VkKhrDeferredHostOperationsExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult> vkCreateDeferredOperationKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void> vkDestroyDeferredOperationKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint> vkGetDeferredOperationMaxConcurrencyKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkResult> vkGetDeferredOperationResultKHR;
    public delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkResult> vkDeferredOperationJoinKHR;
}