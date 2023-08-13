using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRayTracingShaderGroupCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkRayTracingShaderGroupTypeKHR Type;
    public uint GeneralShader;
    public uint ClosestHitShader;
    public uint AnyHitShader;
    public uint IntersectionShader;
    public void* PShaderGroupCaptureReplayHandle;
}