using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV
{
    public VkStructureType SType;
    public void* PNext;
    public uint ShaderGroupHandleSize;
    public uint MaxRecursionDepth;
    public uint MaxShaderGroupStride;
    public uint ShaderGroupBaseAlignment;
    public ulong MaxGeometryCount;
    public ulong MaxInstanceCount;
    public ulong MaxTriangleCount;
    public uint MaxDescriptorSetAccelerationStructures;
}