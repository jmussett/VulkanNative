using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtColorWriteEnableExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkBool32*, void> _vkCmdSetColorWriteEnableEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* pColorWriteEnables)
    {
        _vkCmdSetColorWriteEnableEXT(commandBuffer, attachmentCount, pColorWriteEnables);
    }
}