using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public ulong maxGeometryCount;
    public ulong maxInstanceCount;
    public ulong maxPrimitiveCount;
    public uint maxPerStageDescriptorAccelerationStructures;
    public uint maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
    public uint maxDescriptorSetAccelerationStructures;
    public uint maxDescriptorSetUpdateAfterBindAccelerationStructures;
    public uint minAccelerationStructureScratchOffsetAlignment;

    public VkPhysicalDeviceAccelerationStructurePropertiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR;
    }
}