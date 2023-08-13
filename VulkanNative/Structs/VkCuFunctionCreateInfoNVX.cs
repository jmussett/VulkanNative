using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuFunctionCreateInfoNVX
{
    public VkStructureType SType;
    public void* PNext;
    public VkCuModuleNVX Module;
    public char* PName;
}