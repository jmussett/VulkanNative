using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVariablePointersFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 variablePointersStorageBuffer;
    public VkBool32 variablePointers;
}