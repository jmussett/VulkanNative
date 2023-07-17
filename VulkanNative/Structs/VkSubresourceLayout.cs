using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubresourceLayout
{
    public VkDeviceSize offset;
    public VkDeviceSize size;
    public VkDeviceSize rowPitch;
    public VkDeviceSize arrayPitch;
    public VkDeviceSize depthPitch;
}