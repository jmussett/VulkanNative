using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageProcessing2FeaturesQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 TextureBlockMatch2;
}