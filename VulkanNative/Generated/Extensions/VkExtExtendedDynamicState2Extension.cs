using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtExtendedDynamicState2Extension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> _vkCmdSetPatchControlPointsEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetRasterizerDiscardEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetDepthBiasEnable;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLogicOp, void> _vkCmdSetLogicOpEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void> _vkCmdSetPrimitiveRestartEnable;

    public VkExtExtendedDynamicState2Extension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdSetPatchControlPointsEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdSetPatchControlPointsEXT");
        _vkCmdSetRasterizerDiscardEnable = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetRasterizerDiscardEnable");
        _vkCmdSetDepthBiasEnable = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDepthBiasEnable");
        _vkCmdSetLogicOpEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLogicOp, void>)loader.GetDeviceProcAddr(device, "vkCmdSetLogicOpEXT");
        _vkCmdSetPrimitiveRestartEnable = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkCmdSetPrimitiveRestartEnable");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetPatchControlPointsEXT(VkCommandBuffer commandBuffer, uint patchControlPoints)
    {
        _vkCmdSetPatchControlPointsEXT(commandBuffer, patchControlPoints);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetRasterizerDiscardEnable(VkCommandBuffer commandBuffer, VkBool32 rasterizerDiscardEnable)
    {
        _vkCmdSetRasterizerDiscardEnable(commandBuffer, rasterizerDiscardEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetDepthBiasEnable(VkCommandBuffer commandBuffer, VkBool32 depthBiasEnable)
    {
        _vkCmdSetDepthBiasEnable(commandBuffer, depthBiasEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetLogicOpEXT(VkCommandBuffer commandBuffer, VkLogicOp logicOp)
    {
        _vkCmdSetLogicOpEXT(commandBuffer, logicOp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetPrimitiveRestartEnable(VkCommandBuffer commandBuffer, VkBool32 primitiveRestartEnable)
    {
        _vkCmdSetPrimitiveRestartEnable(commandBuffer, primitiveRestartEnable);
    }
}