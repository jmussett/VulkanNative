using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPresentInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkRect2D srcRect;
    public VkRect2D dstRect;
    public VkBool32 persistent;
}