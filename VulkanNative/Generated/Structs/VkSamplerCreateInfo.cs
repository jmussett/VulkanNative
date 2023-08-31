using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkSamplerCreateFlags flags;
    public VkFilter magFilter;
    public VkFilter minFilter;
    public VkSamplerMipmapMode mipmapMode;
    public VkSamplerAddressMode addressModeU;
    public VkSamplerAddressMode addressModeV;
    public VkSamplerAddressMode addressModeW;
    public float mipLodBias;
    public VkBool32 anisotropyEnable;
    public float maxAnisotropy;
    public VkBool32 compareEnable;
    public VkCompareOp compareOp;
    public float minLod;
    public float maxLod;
    public VkBorderColor borderColor;
    public VkBool32 unnormalizedCoordinates;

    public VkSamplerCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO;
    }
}