using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDebugMarkerExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult> _vkDebugMarkerSetObjectTagEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult> _vkDebugMarkerSetObjectNameEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> _vkCmdDebugMarkerBeginEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void> _vkCmdDebugMarkerEndEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> _vkCmdDebugMarkerInsertEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkDebugMarkerSetObjectTagEXT(VkDevice device, VkDebugMarkerObjectTagInfoEXT* pTagInfo)
    {
        return _vkDebugMarkerSetObjectTagEXT(device, pTagInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkDebugMarkerSetObjectNameEXT(VkDevice device, VkDebugMarkerObjectNameInfoEXT* pNameInfo)
    {
        return _vkDebugMarkerSetObjectNameEXT(device, pNameInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDebugMarkerBeginEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
    {
        _vkCmdDebugMarkerBeginEXT(commandBuffer, pMarkerInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer)
    {
        _vkCmdDebugMarkerEndEXT(commandBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDebugMarkerInsertEXT(VkCommandBuffer commandBuffer, VkDebugMarkerMarkerInfoEXT* pMarkerInfo)
    {
        _vkCmdDebugMarkerInsertEXT(commandBuffer, pMarkerInfo);
    }
}