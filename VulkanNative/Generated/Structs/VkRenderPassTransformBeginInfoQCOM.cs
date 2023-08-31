using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassTransformBeginInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkSurfaceTransformFlagsKHR transform;

    public VkRenderPassTransformBeginInfoQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM;
    }
}