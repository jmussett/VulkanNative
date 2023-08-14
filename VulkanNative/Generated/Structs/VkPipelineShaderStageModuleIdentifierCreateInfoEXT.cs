using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint IdentifierSize;
    public byte* PIdentifier;
}