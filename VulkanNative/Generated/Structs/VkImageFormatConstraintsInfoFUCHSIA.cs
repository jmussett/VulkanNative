using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageFormatConstraintsInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageCreateInfo imageCreateInfo;
    public VkFormatFeatureFlags requiredFormatFeatures;
    public VkImageFormatConstraintsFlagsFUCHSIA flags;
    public ulong sysmemPixelFormat;
    public uint colorSpaceCount;
    public VkSysmemColorSpaceFUCHSIA* pColorSpaces;

    public VkImageFormatConstraintsInfoFUCHSIA()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA;
    }
}