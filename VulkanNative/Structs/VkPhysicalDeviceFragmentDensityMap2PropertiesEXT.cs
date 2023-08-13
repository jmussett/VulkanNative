using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 SubsampledLoads;
    public VkBool32 SubsampledCoarseReconstructionEarlyAccess;
    public uint MaxSubsampledArrayLayers;
    public uint MaxDescriptorSetSubsampledSamplers;
}