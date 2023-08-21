namespace VulkanNative.Examples.HelloTriangle;

internal static class VkResultExtension
{
    public static void ThrowOnError(this VkResult result)
    {
        if (result != VkResult.VK_SUCCESS)
        {
            throw new InvalidOperationException($"Vulkan Error: {result}");
        }
    }
}
