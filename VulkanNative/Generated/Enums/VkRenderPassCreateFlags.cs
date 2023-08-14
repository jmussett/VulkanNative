namespace VulkanNative;

[Flags]
public enum VkRenderPassCreateFlags : uint
{
    VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM = 1U << 1
}