using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkAccelerationStructureTypeKHR Type;
    public VkBuildAccelerationStructureFlagsKHR Flags;
    public uint InstanceCount;
    public uint GeometryCount;
    public VkGeometryNV* PGeometries;
}