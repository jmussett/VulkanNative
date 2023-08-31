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
}