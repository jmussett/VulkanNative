using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceMemoryReportCallbackDataEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceMemoryReportFlagsEXT Flags;
    public VkDeviceMemoryReportEventTypeEXT Type;
    public ulong MemoryObjectId;
    public VkDeviceSize Size;
    public VkObjectType ObjectType;
    public ulong ObjectHandle;
    public uint HeapIndex;
}