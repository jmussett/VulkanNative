using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayModeCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkDisplayModeCreateFlagsKHR Flags;
    public VkDisplayModeParametersKHR Parameters;
}