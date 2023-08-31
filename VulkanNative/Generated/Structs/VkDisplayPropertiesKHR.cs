using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPropertiesKHR
{
    public VkDisplayKHR display;
    public byte* displayName;
    public VkExtent2D physicalDimensions;
    public VkExtent2D physicalResolution;
    public VkSurfaceTransformFlagsKHR supportedTransforms;
    public VkBool32 planeReorderPossible;
    public VkBool32 persistentContent;
}