using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoSessionParametersUpdateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint updateSequenceCount;

    public VkVideoSessionParametersUpdateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR;
    }
}