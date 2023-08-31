using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHdrMetadataEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkXYColorEXT displayPrimaryRed;
    public VkXYColorEXT displayPrimaryGreen;
    public VkXYColorEXT displayPrimaryBlue;
    public VkXYColorEXT whitePoint;
    public float maxLuminance;
    public float minLuminance;
    public float maxContentLightLevel;
    public float maxFrameAverageLightLevel;
}