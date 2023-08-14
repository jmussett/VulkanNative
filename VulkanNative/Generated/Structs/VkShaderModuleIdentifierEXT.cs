using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderModuleIdentifierEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint IdentifierSize;
    public fixed byte Identifier[(int)VulkanApiConstants.VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT];
}