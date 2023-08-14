using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public uint PerViewRenderAreaCount;
    public VkRect2D* PPerViewRenderAreas;
}