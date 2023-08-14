using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI
{
    public VkStructureType SType;
    public void* PNext;
    public fixed uint MaxWorkGroupCount[3];
    public fixed uint MaxWorkGroupSize[3];
    public uint MaxOutputClusterCount;
    public VkDeviceSize IndirectBufferOffsetAlignment;
}