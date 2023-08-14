namespace VulkanNative;

public unsafe class VkAmdShaderInfoExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, VkShaderStageFlags, VkShaderInfoTypeAMD, nint*, void*, VkResult> vkGetShaderInfoAMD;
}