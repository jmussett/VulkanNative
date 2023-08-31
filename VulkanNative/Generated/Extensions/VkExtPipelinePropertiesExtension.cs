using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtPipelinePropertiesExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult> _vkGetPipelinePropertiesEXT;

    public VkExtPipelinePropertiesExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetPipelinePropertiesEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetPipelinePropertiesEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetPipelinePropertiesEXT(VkDevice device, VkPipelineInfoKHR* pPipelineInfo, VkBaseOutStructure* pPipelineProperties)
    {
        return _vkGetPipelinePropertiesEXT(device, pPipelineInfo, pPipelineProperties);
    }
}