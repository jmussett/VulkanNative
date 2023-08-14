using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtLineRasterizationExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, ushort, void> _vkCmdSetLineStippleEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetLineStippleEXT(VkCommandBuffer commandBuffer, uint lineStippleFactor, ushort lineStipplePattern)
    {
        _vkCmdSetLineStippleEXT(commandBuffer, lineStippleFactor, lineStipplePattern);
    }
}