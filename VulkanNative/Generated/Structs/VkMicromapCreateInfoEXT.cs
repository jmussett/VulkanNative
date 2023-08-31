using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkMicromapCreateFlagsEXT createFlags;
    public VkBuffer buffer;
    public VkDeviceSize offset;
    public VkDeviceSize size;
    public VkMicromapTypeEXT type;
    public VkDeviceAddress deviceAddress;

    public VkMicromapCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MICROMAP_CREATE_INFO_EXT;
    }
}