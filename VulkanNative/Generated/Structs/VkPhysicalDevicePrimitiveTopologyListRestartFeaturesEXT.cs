using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 primitiveTopologyListRestart;
    public VkBool32 primitiveTopologyPatchListRestart;

    public VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT;
    }
}