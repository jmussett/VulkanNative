using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayModeCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplayModeCreateFlagsKHR flags;
    public VkDisplayModeParametersKHR parameters;
}