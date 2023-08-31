using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
    public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
    public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
    public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
    public VkBool32 shaderSampledImageArrayNonUniformIndexing;
    public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
    public VkBool32 shaderStorageImageArrayNonUniformIndexing;
    public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
    public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
    public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
    public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
    public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
    public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
    public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
    public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
    public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
    public VkBool32 descriptorBindingUpdateUnusedWhilePending;
    public VkBool32 descriptorBindingPartiallyBound;
    public VkBool32 descriptorBindingVariableDescriptorCount;
    public VkBool32 runtimeDescriptorArray;

    public VkPhysicalDeviceDescriptorIndexingFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES;
    }
}