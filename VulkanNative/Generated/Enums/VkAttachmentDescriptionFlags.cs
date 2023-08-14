namespace VulkanNative;

[Flags]
public enum VkAttachmentDescriptionFlags : uint
{
    VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT = 1U << 0
}