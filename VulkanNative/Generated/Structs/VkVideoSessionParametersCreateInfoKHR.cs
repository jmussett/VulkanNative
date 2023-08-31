using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionParametersCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoSessionParametersCreateFlagsKHR flags;
    public VkVideoSessionParametersKHR videoSessionParametersTemplate;
    public VkVideoSessionKHR videoSession;

    public VkVideoSessionParametersCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR;
    }
}