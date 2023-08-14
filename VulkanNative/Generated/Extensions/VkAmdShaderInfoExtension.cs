using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkAmdShaderInfoExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, VkShaderStageFlags, VkShaderInfoTypeAMD, nint*, void*, VkResult> _vkGetShaderInfoAMD;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, nint* pInfoSize, void* pInfo)
    {
        return _vkGetShaderInfoAMD(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);
    }
}