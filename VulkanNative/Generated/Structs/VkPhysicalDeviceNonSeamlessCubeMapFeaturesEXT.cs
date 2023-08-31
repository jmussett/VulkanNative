using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 nonSeamlessCubeMap;

    public VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NON_SEAMLESS_CUBE_MAP_FEATURES_EXT;
    }
}