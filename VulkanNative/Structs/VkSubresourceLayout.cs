using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubresourceLayout
{
    public VkDeviceSize Offset;
    public VkDeviceSize Size;
    public VkDeviceSize RowPitch;
    public VkDeviceSize ArrayPitch;
    public VkDeviceSize DepthPitch;
}