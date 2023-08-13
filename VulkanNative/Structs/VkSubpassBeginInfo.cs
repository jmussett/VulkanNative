using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassBeginInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkSubpassContents Contents;
}