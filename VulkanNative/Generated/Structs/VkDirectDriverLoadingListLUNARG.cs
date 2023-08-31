using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDirectDriverLoadingListLUNARG
{
    public VkStructureType sType;
    public void* pNext;
    public VkDirectDriverLoadingModeLUNARG mode;
    public uint driverCount;
    public VkDirectDriverLoadingInfoLUNARG* pDrivers;
}