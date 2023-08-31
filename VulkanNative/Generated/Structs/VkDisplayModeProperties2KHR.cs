using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayModeProperties2KHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplayModePropertiesKHR displayModeProperties;

    public VkDisplayModeProperties2KHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR;
    }
}