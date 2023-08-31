using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceOpacityMicromapFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 micromap;
    public VkBool32 micromapCaptureReplay;
    public VkBool32 micromapHostCommands;
}