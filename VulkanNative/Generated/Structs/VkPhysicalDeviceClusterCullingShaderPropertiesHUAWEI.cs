using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI
{
    public VkStructureType sType;
    public void* pNext;
    public fixed uint maxWorkGroupCount[3];
    public fixed uint maxWorkGroupSize[3];
    public uint maxOutputClusterCount;
    public VkDeviceSize indirectBufferOffsetAlignment;
}