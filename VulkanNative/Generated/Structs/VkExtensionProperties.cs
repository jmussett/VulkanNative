using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExtensionProperties
{
    public fixed char ExtensionName[(int)VulkanApiConstants.VK_MAX_EXTENSION_NAME_SIZE];
    public uint SpecVersion;
}