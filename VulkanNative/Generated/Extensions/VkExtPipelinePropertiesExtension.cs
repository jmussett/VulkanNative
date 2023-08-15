using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtPipelinePropertiesExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult> _vkGetPipelinePropertiesEXT;

    public VkExtPipelinePropertiesExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkGetPipelinePropertiesEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPipelinePropertiesEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPipelinePropertiesEXT(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
    {
        return _vkGetPipelinePropertiesEXT(device, pPipelineInfo, pPipelineProperties);
    }
}