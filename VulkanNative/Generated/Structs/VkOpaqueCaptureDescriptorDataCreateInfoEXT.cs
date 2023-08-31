using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpaqueCaptureDescriptorDataCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public void* opaqueCaptureDescriptorData;
}