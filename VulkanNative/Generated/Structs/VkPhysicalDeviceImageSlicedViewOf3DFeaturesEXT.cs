using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 imageSlicedViewOf3D;
}