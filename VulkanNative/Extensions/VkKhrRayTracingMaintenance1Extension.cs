namespace VulkanNative;

public unsafe class VkKhrRayTracingMaintenance1Extension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, void> vkCmdTraceRaysIndirect2KHR;
}