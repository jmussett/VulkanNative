using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrSamplerYcbcrConversionExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult> _vkCreateSamplerYcbcrConversion;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> _vkDestroySamplerYcbcrConversion;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateSamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversionCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkSamplerYcbcrConversion* pYcbcrConversion)
    {
        return _vkCreateSamplerYcbcrConversion(device, pCreateInfo, pAllocator, pYcbcrConversion);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroySamplerYcbcrConversion(VkDevice device, VkSamplerYcbcrConversion ycbcrConversion, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroySamplerYcbcrConversion(device, ycbcrConversion, pAllocator);
    }
}