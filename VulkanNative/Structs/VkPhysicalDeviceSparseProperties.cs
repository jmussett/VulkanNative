using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSparseProperties
{
    public VkBool32 residencyStandard2DBlockShape;
    public VkBool32 residencyStandard2DMultisampleBlockShape;
    public VkBool32 residencyStandard3DBlockShape;
    public VkBool32 residencyAlignedMipSize;
    public VkBool32 residencyNonResidentStrict;
}