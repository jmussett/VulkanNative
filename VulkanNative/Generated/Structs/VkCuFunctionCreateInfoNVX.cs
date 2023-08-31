using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuFunctionCreateInfoNVX
{
    public VkStructureType sType;
    public void* pNext;
    public VkCuModuleNVX module;
    public byte* pName;
}