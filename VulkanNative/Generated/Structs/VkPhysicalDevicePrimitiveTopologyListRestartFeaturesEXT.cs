using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 primitiveTopologyListRestart;
    public VkBool32 primitiveTopologyPatchListRestart;
}