using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtVertexInputDynamicStateExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void> _vkCmdSetVertexInputEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetVertexInputEXT(VkCommandBuffer commandBuffer, uint vertexBindingDescriptionCount, VkVertexInputBindingDescription2EXT* pVertexBindingDescriptions, uint vertexAttributeDescriptionCount, VkVertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
    {
        _vkCmdSetVertexInputEXT(commandBuffer, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, pVertexAttributeDescriptions);
    }
}