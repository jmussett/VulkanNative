using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerBlockMatchWindowCreateInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkExtent2D windowExtent;
    public VkBlockMatchWindowCompareModeQCOM windowCompareMode;
}