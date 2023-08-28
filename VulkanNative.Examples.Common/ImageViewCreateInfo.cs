namespace VulkanNative.Examples.Common;

public struct ImageViewCreateInfo
{
    public VkImage Image;
    public VkImageViewType ViewType;
    public VkFormat Format;
    public VkComponentMapping Components;
    public VkImageSubresourceRange SubresourceRange;
}