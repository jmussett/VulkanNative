using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceCapabilitiesPresentBarrierNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 presentBarrierSupported;

    public VkSurfaceCapabilitiesPresentBarrierNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_BARRIER_NV;
    }
}