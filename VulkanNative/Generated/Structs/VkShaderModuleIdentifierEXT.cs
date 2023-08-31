using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderModuleIdentifierEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint identifierSize;
    public fixed byte identifier[(int)VulkanApiConstants.VK_MAX_SHADER_MODULE_IDENTIFIER_SIZE_EXT];

    public VkShaderModuleIdentifierEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SHADER_MODULE_IDENTIFIER_EXT;
    }
}