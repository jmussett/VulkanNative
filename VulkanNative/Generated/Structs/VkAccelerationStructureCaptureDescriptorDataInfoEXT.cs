using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureCaptureDescriptorDataInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccelerationStructureKHR accelerationStructure;
    public VkAccelerationStructureNV accelerationStructureNV;
}