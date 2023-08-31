using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccelerationStructureTypeKHR type;
    public VkBuildAccelerationStructureFlagsKHR flags;
    public uint instanceCount;
    public uint geometryCount;
    public VkGeometryNV* pGeometries;

    public VkAccelerationStructureInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV;
    }
}