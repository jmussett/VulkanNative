using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugMarkerObjectTagInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDebugReportObjectTypeEXT objectType;
    public ulong @object;
    public ulong tagName;
    public nuint tagSize;
    public void* pTag;

    public VkDebugMarkerObjectTagInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT;
    }
}