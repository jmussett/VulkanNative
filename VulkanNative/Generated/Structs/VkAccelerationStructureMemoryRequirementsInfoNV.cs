using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccelerationStructureMemoryRequirementsTypeNV type;
    public VkAccelerationStructureNV accelerationStructure;
}