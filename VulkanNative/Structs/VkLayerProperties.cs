using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkLayerProperties
{
    public fixed char layerName[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
    public uint specVersion;
    public uint implementationVersion;
    public fixed char description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
}