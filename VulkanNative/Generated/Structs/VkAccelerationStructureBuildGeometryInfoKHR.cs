using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureBuildGeometryInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccelerationStructureTypeKHR type;
    public VkBuildAccelerationStructureFlagsKHR flags;
    public VkBuildAccelerationStructureModeKHR mode;
    public VkAccelerationStructureKHR srcAccelerationStructure;
    public VkAccelerationStructureKHR dstAccelerationStructure;
    public uint geometryCount;
    public VkAccelerationStructureGeometryKHR* pGeometries;
    public VkAccelerationStructureGeometryKHR** ppGeometries;
    public VkDeviceOrHostAddressKHR scratchData;

    public VkAccelerationStructureBuildGeometryInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR;
    }
}