using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 BorderColorSwizzle;
    public VkBool32 BorderColorSwizzleFromImage;
}