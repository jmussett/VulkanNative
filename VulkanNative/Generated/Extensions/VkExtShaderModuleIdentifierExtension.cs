using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtShaderModuleIdentifierExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void> _vkGetShaderModuleIdentifierEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void> _vkGetShaderModuleCreateInfoIdentifierEXT;

    public VkExtShaderModuleIdentifierExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkGetShaderModuleIdentifierEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void>)loader.GetDeviceProcAddr(device, "vkGetShaderModuleIdentifierEXT");
        _vkGetShaderModuleCreateInfoIdentifierEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void>)loader.GetDeviceProcAddr(device, "vkGetShaderModuleCreateInfoIdentifierEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetShaderModuleIdentifierEXT(VkDevice device, VkShaderModule shaderModule, VkShaderModuleIdentifierEXT* pIdentifier)
    {
        _vkGetShaderModuleIdentifierEXT(device, shaderModule, pIdentifier);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetShaderModuleCreateInfoIdentifierEXT(VkDevice device, VkShaderModuleCreateInfo* pCreateInfo, VkShaderModuleIdentifierEXT* pIdentifier)
    {
        _vkGetShaderModuleCreateInfoIdentifierEXT(device, pCreateInfo, pIdentifier);
    }
}