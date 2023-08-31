using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccelerationStructureMemoryRequirementsTypeNV type;
    public VkAccelerationStructureNV accelerationStructure;

    public VkAccelerationStructureMemoryRequirementsInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV;
    }
}