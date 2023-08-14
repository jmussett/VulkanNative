using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfacePresentScalingCapabilitiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkPresentScalingFlagsEXT SupportedPresentScaling;
    public VkPresentGravityFlagsEXT SupportedPresentGravityX;
    public VkPresentGravityFlagsEXT SupportedPresentGravityY;
    public VkExtent2D MinScaledImageExtent;
    public VkExtent2D MaxScaledImageExtent;
}