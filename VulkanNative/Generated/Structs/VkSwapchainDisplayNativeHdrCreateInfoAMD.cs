using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 localDimmingEnable;

    public VkSwapchainDisplayNativeHdrCreateInfoAMD()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD;
    }
}