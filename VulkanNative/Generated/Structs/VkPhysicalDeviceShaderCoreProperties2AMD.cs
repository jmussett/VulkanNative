using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkShaderCorePropertiesFlagsAMD shaderCoreFeatures;
    public uint activeComputeUnitCount;
}