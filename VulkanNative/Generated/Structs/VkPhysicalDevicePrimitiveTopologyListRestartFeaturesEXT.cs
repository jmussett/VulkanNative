using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 PrimitiveTopologyListRestart;
    public VkBool32 PrimitiveTopologyPatchListRestart;
}