using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkLayerProperties
{
    public fixed byte layerName[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
    public uint specVersion;
    public uint implementationVersion;
    public fixed byte description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
}