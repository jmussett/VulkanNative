using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtPipelinePropertiesExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult> _vkGetPipelinePropertiesEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPipelinePropertiesEXT(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
    {
        return _vkGetPipelinePropertiesEXT(device, pPipelineInfo, pPipelineProperties);
    }
}