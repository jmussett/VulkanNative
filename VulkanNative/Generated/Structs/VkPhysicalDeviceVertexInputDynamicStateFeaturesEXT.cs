using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 vertexInputDynamicState;

    public VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT;
    }
}