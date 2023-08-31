using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderModuleCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkShaderModuleCreateFlags flags;
    public nuint codeSize;
    public uint* pCode;

    public VkShaderModuleCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO;
    }
}