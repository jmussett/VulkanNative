using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDirectDriverLoadingListLUNARG
{
    public VkStructureType SType;
    public void* PNext;
    public VkDirectDriverLoadingModeLUNARG Mode;
    public uint DriverCount;
    public VkDirectDriverLoadingInfoLUNARG* PDrivers;
}