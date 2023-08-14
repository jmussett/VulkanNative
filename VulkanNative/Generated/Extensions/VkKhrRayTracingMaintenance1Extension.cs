using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrRayTracingMaintenance1Extension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, void> _vkCmdTraceRaysIndirect2KHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdTraceRaysIndirect2KHR(VkCommandBuffer commandBuffer, VkDeviceAddress indirectDeviceAddress)
    {
        _vkCmdTraceRaysIndirect2KHR(commandBuffer, indirectDeviceAddress);
    }
}