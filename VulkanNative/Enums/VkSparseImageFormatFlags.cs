namespace VulkanNative;

[Flags]
public enum VkSparseImageFormatFlags : uint
{
    VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT = 1U << 0,
    VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT = 1U << 1,
    VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT = 1U << 2
}