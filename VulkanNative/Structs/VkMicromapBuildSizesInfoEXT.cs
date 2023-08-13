using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapBuildSizesInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceSize MicromapSize;
    public VkDeviceSize BuildScratchSize;
    public VkBool32 Discardable;
}