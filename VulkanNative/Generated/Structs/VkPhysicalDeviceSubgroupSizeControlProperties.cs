using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSubgroupSizeControlProperties
{
    public VkStructureType SType;
    public void* PNext;
    public uint MinSubgroupSize;
    public uint MaxSubgroupSize;
    public uint MaxComputeWorkgroupSubgroups;
    public VkShaderStageFlags RequiredSubgroupSizeStages;
}