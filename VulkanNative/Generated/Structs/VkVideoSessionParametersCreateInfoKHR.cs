using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionParametersCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkVideoSessionParametersCreateFlagsKHR Flags;
    public VkVideoSessionParametersKHR VideoSessionParametersTemplate;
    public VkVideoSessionKHR VideoSession;
}