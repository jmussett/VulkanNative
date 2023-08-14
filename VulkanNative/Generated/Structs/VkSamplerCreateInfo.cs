using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkSamplerCreateFlags Flags;
    public VkFilter MagFilter;
    public VkFilter MinFilter;
    public VkSamplerMipmapMode MipmapMode;
    public VkSamplerAddressMode AddressModeU;
    public VkSamplerAddressMode AddressModeV;
    public VkSamplerAddressMode AddressModeW;
    public float MipLodBias;
    public VkBool32 AnisotropyEnable;
    public float MaxAnisotropy;
    public VkBool32 CompareEnable;
    public VkCompareOp CompareOp;
    public float MinLod;
    public float MaxLod;
    public VkBorderColor BorderColor;
    public VkBool32 UnnormalizedCoordinates;
}