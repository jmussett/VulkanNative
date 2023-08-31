using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfacePresentScalingCapabilitiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkPresentScalingFlagsEXT supportedPresentScaling;
    public VkPresentGravityFlagsEXT supportedPresentGravityX;
    public VkPresentGravityFlagsEXT supportedPresentGravityY;
    public VkExtent2D minScaledImageExtent;
    public VkExtent2D maxScaledImageExtent;
}