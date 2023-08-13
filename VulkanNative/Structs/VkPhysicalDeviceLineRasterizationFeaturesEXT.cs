using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 RectangularLines;
    public VkBool32 BresenhamLines;
    public VkBool32 SmoothLines;
    public VkBool32 StippledRectangularLines;
    public VkBool32 StippledBresenhamLines;
    public VkBool32 StippledSmoothLines;
}