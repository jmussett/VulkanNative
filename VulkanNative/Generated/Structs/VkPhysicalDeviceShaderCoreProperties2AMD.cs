using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
{
    public VkStructureType SType;
    public void* PNext;
    public VkShaderCorePropertiesFlagsAMD ShaderCoreFeatures;
    public uint ActiveComputeUnitCount;
}