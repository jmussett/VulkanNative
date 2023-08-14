using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceHostImageCopyPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint CopySrcLayoutCount;
    public VkImageLayout* PCopySrcLayouts;
    public uint CopyDstLayoutCount;
    public VkImageLayout* PCopyDstLayouts;
    public fixed byte OptimalTilingLayoutUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public VkBool32 IdenticalMemoryTypeRequirements;
}