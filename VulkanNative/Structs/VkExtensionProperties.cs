using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExtensionProperties
{
    public char extensionName;
    public uint specVersion;
}