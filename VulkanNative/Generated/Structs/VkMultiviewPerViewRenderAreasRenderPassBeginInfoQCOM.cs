using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public uint perViewRenderAreaCount;
    public VkRect2D* pPerViewRenderAreas;

    public VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM;
    }
}