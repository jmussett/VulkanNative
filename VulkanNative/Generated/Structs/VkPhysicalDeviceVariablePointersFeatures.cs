using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVariablePointersFeatures
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 VariablePointersStorageBuffer;
    public VkBool32 VariablePointers;
}