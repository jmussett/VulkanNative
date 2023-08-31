using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassDependency2
{
    public VkStructureType sType;
    public void* pNext;
    public uint srcSubpass;
    public uint dstSubpass;
    public VkPipelineStageFlags srcStageMask;
    public VkPipelineStageFlags dstStageMask;
    public VkAccessFlags srcAccessMask;
    public VkAccessFlags dstAccessMask;
    public VkDependencyFlags dependencyFlags;
    public int viewOffset;

    public VkSubpassDependency2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2;
    }
}