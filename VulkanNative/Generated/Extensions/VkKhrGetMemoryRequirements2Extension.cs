using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrGetMemoryRequirements2Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> _vkGetImageMemoryRequirements2;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> _vkGetBufferMemoryRequirements2;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void> _vkGetImageSparseMemoryRequirements2;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetImageMemoryRequirements2(VkDevice device, VkImageMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
        _vkGetImageMemoryRequirements2(device, pInfo, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetBufferMemoryRequirements2(VkDevice device, VkBufferMemoryRequirementsInfo2* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
        _vkGetBufferMemoryRequirements2(device, pInfo, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetImageSparseMemoryRequirements2(VkDevice device, VkImageSparseMemoryRequirementsInfo2* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
    {
        _vkGetImageSparseMemoryRequirements2(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
    }
}