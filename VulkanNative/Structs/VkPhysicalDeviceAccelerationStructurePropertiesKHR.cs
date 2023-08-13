using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public ulong MaxGeometryCount;
    public ulong MaxInstanceCount;
    public ulong MaxPrimitiveCount;
    public uint MaxPerStageDescriptorAccelerationStructures;
    public uint MaxPerStageDescriptorUpdateAfterBindAccelerationStructures;
    public uint MaxDescriptorSetAccelerationStructures;
    public uint MaxDescriptorSetUpdateAfterBindAccelerationStructures;
    public uint MinAccelerationStructureScratchOffsetAlignment;
}