using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageFormatConstraintsInfoFUCHSIA
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageCreateInfo ImageCreateInfo;
    public VkFormatFeatureFlags RequiredFormatFeatures;
    public VkImageFormatConstraintsFlagsFUCHSIA Flags;
    public ulong SysmemPixelFormat;
    public uint ColorSpaceCount;
    public VkSysmemColorSpaceFUCHSIA* PColorSpaces;
}