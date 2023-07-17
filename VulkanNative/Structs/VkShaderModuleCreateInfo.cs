using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderModuleCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkShaderModuleCreateFlags flags;
    public nint codeSize;
    public uint* pCode;
}