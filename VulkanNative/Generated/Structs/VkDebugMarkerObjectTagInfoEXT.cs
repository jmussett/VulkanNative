using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugMarkerObjectTagInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDebugReportObjectTypeEXT ObjectType;
    public ulong Object;
    public ulong TagName;
    public nuint TagSize;
    public void* PTag;
}