using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrMaintenance3Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void> _vkGetDescriptorSetLayoutSupport;

    public VkKhrMaintenance3Extension(VkDevice device, IVulkanLoader loader)
    {
        _vkGetDescriptorSetLayoutSupport = (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void>)loader.GetDeviceProcAddr(device, "vkGetDescriptorSetLayoutSupport");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
    {
        _vkGetDescriptorSetLayoutSupport(device, pCreateInfo, pSupport);
    }
}