using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueryLowLatencySupportNV
{
    public VkStructureType SType;
    public void* PNext;
    public void* PQueriedLowLatencyData;
}