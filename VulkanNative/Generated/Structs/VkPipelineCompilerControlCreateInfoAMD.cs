using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCompilerControlCreateInfoAMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCompilerControlFlagsAMD compilerControlFlags;

    public VkPipelineCompilerControlCreateInfoAMD()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD;
    }
}