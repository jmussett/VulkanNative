using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassMultiviewCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint subpassCount;
    public uint* pViewMasks;
    public uint dependencyCount;
    public int* pViewOffsets;
    public uint correlationMaskCount;
    public uint* pCorrelationMasks;

    public VkRenderPassMultiviewCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO;
    }
}