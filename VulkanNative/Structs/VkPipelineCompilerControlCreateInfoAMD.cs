using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCompilerControlCreateInfoAMD
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineCompilerControlFlagsAMD CompilerControlFlags;
}