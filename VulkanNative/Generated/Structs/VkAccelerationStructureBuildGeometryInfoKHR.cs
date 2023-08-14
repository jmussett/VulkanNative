using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureBuildGeometryInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkAccelerationStructureTypeKHR Type;
    public VkBuildAccelerationStructureFlagsKHR Flags;
    public VkBuildAccelerationStructureModeKHR Mode;
    public VkAccelerationStructureKHR SrcAccelerationStructure;
    public VkAccelerationStructureKHR DstAccelerationStructure;
    public uint GeometryCount;
    public VkAccelerationStructureGeometryKHR* PGeometries;
    public VkAccelerationStructureGeometryKHR** PpGeometries;
    public VkDeviceOrHostAddressKHR ScratchData;
}