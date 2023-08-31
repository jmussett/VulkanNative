using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 advancedBlendCoherentOperations;

    public VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT;
    }
}