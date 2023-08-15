using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtColorWriteEnableExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkBool32*, void> _vkCmdSetColorWriteEnableEXT;

    public VkExtColorWriteEnableExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkCmdSetColorWriteEnableEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkBool32*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetColorWriteEnableEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetColorWriteEnableEXT(VkCommandBuffer commandBuffer, uint attachmentCount, VkBool32* pColorWriteEnables)
    {
        _vkCmdSetColorWriteEnableEXT(commandBuffer, attachmentCount, pColorWriteEnables);
    }
}