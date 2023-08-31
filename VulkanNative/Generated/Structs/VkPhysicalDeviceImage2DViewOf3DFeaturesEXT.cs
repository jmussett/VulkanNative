using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 image2DViewOf3D;
    public VkBool32 sampler2DViewOf3D;
}