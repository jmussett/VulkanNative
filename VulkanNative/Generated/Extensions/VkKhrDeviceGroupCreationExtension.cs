using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrDeviceGroupCreationExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult> _vkEnumeratePhysicalDeviceGroups;

    public VkKhrDeviceGroupCreationExtension(VkInstance instance, IFunctionLoader loader)
    {
        _vkEnumeratePhysicalDeviceGroups = (delegate* unmanaged[Cdecl]<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult>)loader.GetInstanceProcAddr(instance, "vkEnumeratePhysicalDeviceGroups");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkEnumeratePhysicalDeviceGroups(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
    {
        return _vkEnumeratePhysicalDeviceGroups(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
    }
}