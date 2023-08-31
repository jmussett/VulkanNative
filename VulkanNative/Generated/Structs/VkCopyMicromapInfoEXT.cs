using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMicromapInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkMicromapEXT src;
    public VkMicromapEXT dst;
    public VkCopyMicromapModeEXT mode;
}