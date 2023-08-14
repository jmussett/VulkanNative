using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPropertiesKHR
{
    public VkDisplayKHR Display;
    public char* DisplayName;
    public VkExtent2D PhysicalDimensions;
    public VkExtent2D PhysicalResolution;
    public VkSurfaceTransformFlagsKHR SupportedTransforms;
    public VkBool32 PlaneReorderPossible;
    public VkBool32 PersistentContent;
}