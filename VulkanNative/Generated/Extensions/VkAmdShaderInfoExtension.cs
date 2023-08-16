using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkAmdShaderInfoExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, VkShaderStageFlags, VkShaderInfoTypeAMD, nint*, void*, VkResult> _vkGetShaderInfoAMD;

    public VkAmdShaderInfoExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetShaderInfoAMD = (delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, VkShaderStageFlags, VkShaderInfoTypeAMD, nint*, void*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetShaderInfoAMD");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetShaderInfoAMD(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, nint* pInfoSize, void* pInfo)
    {
        return _vkGetShaderInfoAMD(device, pipeline, shaderStage, infoType, pInfoSize, pInfo);
    }
}