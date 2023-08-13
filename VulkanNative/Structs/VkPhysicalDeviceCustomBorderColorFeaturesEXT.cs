using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 CustomBorderColors;
    public VkBool32 CustomBorderColorWithoutFormat;
}