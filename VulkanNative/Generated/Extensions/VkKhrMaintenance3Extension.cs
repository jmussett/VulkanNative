using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrMaintenance3Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void> _vkGetDescriptorSetLayoutSupport;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDescriptorSetLayoutSupport(VkDevice device, VkDescriptorSetLayoutCreateInfo* pCreateInfo, VkDescriptorSetLayoutSupport* pSupport)
    {
        _vkGetDescriptorSetLayoutSupport(device, pCreateInfo, pSupport);
    }
}