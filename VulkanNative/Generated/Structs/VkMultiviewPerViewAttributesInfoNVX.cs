using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultiviewPerViewAttributesInfoNVX
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 PerViewAttributes;
    public VkBool32 PerViewAttributesPositionXOnly;
}