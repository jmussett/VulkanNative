using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugMarkerObjectNameInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDebugReportObjectTypeEXT objectType;
    public ulong @object;
    public byte* pObjectName;

    public VkDebugMarkerObjectNameInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT;
    }
}