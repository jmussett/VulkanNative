using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugMarkerMarkerInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public byte* pMarkerName;
    public fixed float color[4];

    public VkDebugMarkerMarkerInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT;
    }
}