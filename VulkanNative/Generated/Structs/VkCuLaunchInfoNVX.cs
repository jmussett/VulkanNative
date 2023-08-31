using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuLaunchInfoNVX
{
    public VkStructureType sType;
    public void* pNext;
    public VkCuFunctionNVX function;
    public uint gridDimX;
    public uint gridDimY;
    public uint gridDimZ;
    public uint blockDimX;
    public uint blockDimY;
    public uint blockDimZ;
    public uint sharedMemBytes;
    public nuint paramCount;
    public void** pParams;
    public nuint extraCount;
    public void** pExtras;

    public VkCuLaunchInfoNVX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX;
    }
}