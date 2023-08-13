using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkAccelerationStructureMemoryRequirementsTypeNV Type;
    public VkAccelerationStructureNV AccelerationStructure;
}