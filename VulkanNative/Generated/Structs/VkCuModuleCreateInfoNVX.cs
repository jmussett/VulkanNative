using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuModuleCreateInfoNVX
{
    public VkStructureType sType;
    public void* pNext;
    public nuint dataSize;
    public void* pData;
}