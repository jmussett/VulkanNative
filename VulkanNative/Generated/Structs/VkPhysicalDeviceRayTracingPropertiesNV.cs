using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint shaderGroupHandleSize;
    public uint maxRecursionDepth;
    public uint maxShaderGroupStride;
    public uint shaderGroupBaseAlignment;
    public ulong maxGeometryCount;
    public ulong maxInstanceCount;
    public ulong maxTriangleCount;
    public uint maxDescriptorSetAccelerationStructures;
}