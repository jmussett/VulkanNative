using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 customBorderColors;
    public VkBool32 customBorderColorWithoutFormat;
}