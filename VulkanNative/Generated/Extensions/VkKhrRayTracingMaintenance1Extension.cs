using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrRayTracingMaintenance1Extension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, void> _vkCmdTraceRaysIndirect2KHR;

    public VkKhrRayTracingMaintenance1Extension(VkDevice device, IVulkanLoader loader)
    {
        _vkCmdTraceRaysIndirect2KHR = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, void>)loader.GetDeviceProcAddr(device, "vkCmdTraceRaysIndirect2KHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdTraceRaysIndirect2KHR(VkCommandBuffer commandBuffer, VkDeviceAddress indirectDeviceAddress)
    {
        _vkCmdTraceRaysIndirect2KHR(commandBuffer, indirectDeviceAddress);
    }
}