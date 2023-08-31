using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAccelerationStructureCaptureDescriptorDataInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkAccelerationStructureKHR accelerationStructure;
    public VkAccelerationStructureNV accelerationStructureNV;

    public VkAccelerationStructureCaptureDescriptorDataInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT;
    }
}