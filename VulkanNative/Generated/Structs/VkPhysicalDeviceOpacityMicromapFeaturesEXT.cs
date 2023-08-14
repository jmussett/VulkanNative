using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceOpacityMicromapFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 Micromap;
    public VkBool32 MicromapCaptureReplay;
    public VkBool32 MicromapHostCommands;
}