using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPresentInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkRect2D SrcRect;
    public VkRect2D DstRect;
    public VkBool32 Persistent;
}