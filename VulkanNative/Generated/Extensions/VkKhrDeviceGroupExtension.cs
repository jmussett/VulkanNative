using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrDeviceGroupExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlags*, void> _vkGetDeviceGroupPeerMemoryFeatures;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, void> _vkCmdSetDeviceMask;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void> _vkCmdDispatchBase;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult> _vkGetDeviceGroupPresentCapabilitiesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult> _vkGetDeviceGroupSurfacePresentModesKHR;
    private delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult> _vkGetPhysicalDevicePresentRectanglesKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult> _vkAcquireNextImage2KHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceGroupPeerMemoryFeatures(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, VkPeerMemoryFeatureFlags* pPeerMemoryFeatures)
    {
        _vkGetDeviceGroupPeerMemoryFeatures(device, heapIndex, localDeviceIndex, remoteDeviceIndex, pPeerMemoryFeatures);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDeviceMask(VkCommandBuffer commandBuffer, uint deviceMask)
    {
        _vkCmdSetDeviceMask(commandBuffer, deviceMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDispatchBase(VkCommandBuffer commandBuffer, uint baseGroupX, uint baseGroupY, uint baseGroupZ, uint groupCountX, uint groupCountY, uint groupCountZ)
    {
        _vkCmdDispatchBase(commandBuffer, baseGroupX, baseGroupY, baseGroupZ, groupCountX, groupCountY, groupCountZ);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDeviceGroupPresentCapabilitiesKHR(VkDevice device, VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities)
    {
        return _vkGetDeviceGroupPresentCapabilitiesKHR(device, pDeviceGroupPresentCapabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDeviceGroupSurfacePresentModesKHR(VkDevice device, VkSurfaceKHR surface, VkDeviceGroupPresentModeFlagsKHR* pModes)
    {
        return _vkGetDeviceGroupSurfacePresentModesKHR(device, surface, pModes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice, VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects)
    {
        return _vkGetPhysicalDevicePresentRectanglesKHR(physicalDevice, surface, pRectCount, pRects);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkAcquireNextImage2KHR(VkDevice device, VkAcquireNextImageInfoKHR* pAcquireInfo, uint* pImageIndex)
    {
        return _vkAcquireNextImage2KHR(device, pAcquireInfo, pImageIndex);
    }
}