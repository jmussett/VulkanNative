using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerCaptureDescriptorDataInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkSampler sampler;
}