using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 decodeModeSharedExponent;

    public VkPhysicalDeviceASTCDecodeFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT;
    }
}