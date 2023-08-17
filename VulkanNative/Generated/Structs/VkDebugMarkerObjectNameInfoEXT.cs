using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugMarkerObjectNameInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDebugReportObjectTypeEXT ObjectType;
    public ulong Object;
    public byte* PObjectName;
}