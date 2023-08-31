using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainPresentBarrierCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 presentBarrierEnable;

    public VkSwapchainPresentBarrierCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_BARRIER_CREATE_INFO_NV;
    }
}