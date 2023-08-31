using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtLineRasterizationExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, ushort, void> _vkCmdSetLineStippleEXT;

    public VkExtLineRasterizationExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdSetLineStippleEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, ushort, void>)loader.GetDeviceProcAddr(device, "vkCmdSetLineStippleEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
    {
        _vkCmdSetLineStippleEXT(commandBuffer, lineStippleFactor, lineStipplePattern);
    }
}