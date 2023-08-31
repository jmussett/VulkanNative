using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugMarkerMarkerInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public byte* pMarkerName;
    public fixed float color[4];
}