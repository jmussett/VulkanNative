using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerCaptureDescriptorDataInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkSampler Sampler;
}