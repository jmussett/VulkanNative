using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageProcessingFeaturesQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 TextureSampleWeighted;
    public VkBool32 TextureBoxFilter;
    public VkBool32 TextureBlockMatch;
}