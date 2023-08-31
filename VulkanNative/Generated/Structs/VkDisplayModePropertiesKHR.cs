using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayModePropertiesKHR
{
    public VkDisplayModeKHR displayMode;
    public VkDisplayModeParametersKHR parameters;
}