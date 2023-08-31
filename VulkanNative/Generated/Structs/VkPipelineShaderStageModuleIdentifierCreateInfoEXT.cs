using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint identifierSize;
    public byte* pIdentifier;
}