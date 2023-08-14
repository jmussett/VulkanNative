using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureCaptureDescriptorDataInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkAccelerationStructureKHR AccelerationStructure;
    public VkAccelerationStructureNV AccelerationStructureNV;
}