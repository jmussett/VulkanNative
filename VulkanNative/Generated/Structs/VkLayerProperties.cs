using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkLayerProperties
{
    public fixed byte LayerName[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
    public uint SpecVersion;
    public uint ImplementationVersion;
    public fixed byte Description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
}