using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 Image2DViewOf3D;
    public VkBool32 Sampler2DViewOf3D;
}