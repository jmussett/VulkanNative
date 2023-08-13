using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSparseProperties
{
    public VkBool32 ResidencyStandard2DBlockShape;
    public VkBool32 ResidencyStandard2DMultisampleBlockShape;
    public VkBool32 ResidencyStandard3DBlockShape;
    public VkBool32 ResidencyAlignedMipSize;
    public VkBool32 ResidencyNonResidentStrict;
}