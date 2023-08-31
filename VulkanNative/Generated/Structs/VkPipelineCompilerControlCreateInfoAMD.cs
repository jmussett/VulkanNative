using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCompilerControlCreateInfoAMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCompilerControlFlagsAMD compilerControlFlags;
}