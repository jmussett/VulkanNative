using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPowerInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplayPowerStateEXT powerState;

    public VkDisplayPowerInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT;
    }
}