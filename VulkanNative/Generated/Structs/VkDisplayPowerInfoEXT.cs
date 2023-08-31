using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPowerInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplayPowerStateEXT powerState;
}