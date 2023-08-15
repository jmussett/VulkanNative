using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDiscardRectanglesExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkRect2D*, void> _vkCmdSetDiscardRectangleEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDiscardRectangleEnableEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDiscardRectangleModeEXT, void> _vkCmdSetDiscardRectangleModeEXT;

    public VkExtDiscardRectanglesExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkCmdSetDiscardRectangleEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkRect2D*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDiscardRectangleEXT");
        _vkCmdSetDiscardRectangleEnableEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDiscardRectangleEnableEXT");
        _vkCmdSetDiscardRectangleModeEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDiscardRectangleModeEXT, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDiscardRectangleModeEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDiscardRectangleEXT(VkCommandBuffer commandBuffer, uint firstDiscardRectangle, uint discardRectangleCount, VkRect2D* pDiscardRectangles)
    {
        _vkCmdSetDiscardRectangleEXT(commandBuffer, firstDiscardRectangle, discardRectangleCount, pDiscardRectangles);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDiscardRectangleEnableEXT(VkCommandBuffer commandBuffer, VkBool32 discardRectangleEnable)
    {
        _vkCmdSetDiscardRectangleEnableEXT(commandBuffer, discardRectangleEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDiscardRectangleModeEXT(VkCommandBuffer commandBuffer, VkDiscardRectangleModeEXT discardRectangleMode)
    {
        _vkCmdSetDiscardRectangleModeEXT(commandBuffer, discardRectangleMode);
    }
}