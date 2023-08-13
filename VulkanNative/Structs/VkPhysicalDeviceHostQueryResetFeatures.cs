using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceHostQueryResetFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 hostQueryReset;
}