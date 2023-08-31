using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public uint perViewRenderAreaCount;
    public VkRect2D* pPerViewRenderAreas;
}