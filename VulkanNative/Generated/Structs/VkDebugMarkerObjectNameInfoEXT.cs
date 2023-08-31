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
}