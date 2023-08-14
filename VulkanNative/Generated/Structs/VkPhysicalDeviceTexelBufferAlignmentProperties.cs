using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentProperties
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceSize StorageTexelBufferOffsetAlignmentBytes;
    public VkBool32 StorageTexelBufferOffsetSingleTexelAlignment;
    public VkDeviceSize UniformTexelBufferOffsetAlignmentBytes;
    public VkBool32 UniformTexelBufferOffsetSingleTexelAlignment;
}