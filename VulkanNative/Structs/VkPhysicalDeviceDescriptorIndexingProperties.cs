using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxUpdateAfterBindDescriptorsInAllPools;
    public VkBool32 ShaderUniformBufferArrayNonUniformIndexingNative;
    public VkBool32 ShaderSampledImageArrayNonUniformIndexingNative;
    public VkBool32 ShaderStorageBufferArrayNonUniformIndexingNative;
    public VkBool32 ShaderStorageImageArrayNonUniformIndexingNative;
    public VkBool32 ShaderInputAttachmentArrayNonUniformIndexingNative;
    public VkBool32 RobustBufferAccessUpdateAfterBind;
    public VkBool32 QuadDivergentImplicitLod;
    public uint MaxPerStageDescriptorUpdateAfterBindSamplers;
    public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;
    public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;
    public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;
    public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;
    public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;
    public uint MaxPerStageUpdateAfterBindResources;
    public uint MaxDescriptorSetUpdateAfterBindSamplers;
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
    public uint MaxDescriptorSetUpdateAfterBindSampledImages;
    public uint MaxDescriptorSetUpdateAfterBindStorageImages;
    public uint MaxDescriptorSetUpdateAfterBindInputAttachments;
}