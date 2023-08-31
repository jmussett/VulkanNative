using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapVersionInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public byte* pVersionData;

    public VkMicromapVersionInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MICROMAP_VERSION_INFO_EXT;
    }
}