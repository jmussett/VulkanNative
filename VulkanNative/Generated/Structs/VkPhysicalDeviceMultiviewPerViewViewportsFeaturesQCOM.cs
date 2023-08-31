using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 multiviewPerViewViewports;
}