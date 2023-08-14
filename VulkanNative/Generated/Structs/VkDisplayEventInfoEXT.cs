using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayEventInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDisplayEventTypeEXT DisplayEvent;
}