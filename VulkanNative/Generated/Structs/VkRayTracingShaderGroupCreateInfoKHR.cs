using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRayTracingShaderGroupCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkRayTracingShaderGroupTypeKHR type;
    public uint generalShader;
    public uint closestHitShader;
    public uint anyHitShader;
    public uint intersectionShader;
    public void* pShaderGroupCaptureReplayHandle;

    public VkRayTracingShaderGroupCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR;
    }
}