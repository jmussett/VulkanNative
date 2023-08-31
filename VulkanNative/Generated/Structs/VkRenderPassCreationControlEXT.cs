using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassCreationControlEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 disallowMerging;

    public VkRenderPassCreationControlEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT;
    }
}