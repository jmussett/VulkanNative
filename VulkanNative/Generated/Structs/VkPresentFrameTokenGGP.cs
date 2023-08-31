using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentFrameTokenGGP
{
    public VkStructureType sType;
    public void* pNext;
    public nint frameToken;

    public VkPresentFrameTokenGGP()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP;
    }
}