using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHdrMetadataEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkXYColorEXT DisplayPrimaryRed;
    public VkXYColorEXT DisplayPrimaryGreen;
    public VkXYColorEXT DisplayPrimaryBlue;
    public VkXYColorEXT WhitePoint;
    public float MaxLuminance;
    public float MinLuminance;
    public float MaxContentLightLevel;
    public float MaxFrameAverageLightLevel;
}