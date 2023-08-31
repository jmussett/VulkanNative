using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVariablePointersFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 variablePointersStorageBuffer;
    public VkBool32 variablePointers;

    public VkPhysicalDeviceVariablePointersFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES;
    }
}