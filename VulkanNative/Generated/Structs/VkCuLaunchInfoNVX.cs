using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuLaunchInfoNVX
{
    public VkStructureType SType;
    public void* PNext;
    public VkCuFunctionNVX Function;
    public uint GridDimX;
    public uint GridDimY;
    public uint GridDimZ;
    public uint BlockDimX;
    public uint BlockDimY;
    public uint BlockDimZ;
    public uint SharedMemBytes;
    public nuint ParamCount;
    public void** PParams;
    public nuint ExtraCount;
    public void** PExtras;
}