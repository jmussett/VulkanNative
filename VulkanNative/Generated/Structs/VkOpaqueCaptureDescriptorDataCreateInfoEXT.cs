using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpaqueCaptureDescriptorDataCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public void* OpaqueCaptureDescriptorData;
}