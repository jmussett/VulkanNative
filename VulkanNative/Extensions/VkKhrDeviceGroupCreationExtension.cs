using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrDeviceGroupCreationExtension
{
    private delegate* unmanaged[Cdecl]<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult> _vkEnumeratePhysicalDeviceGroups;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkEnumeratePhysicalDeviceGroups(VkInstance instance, uint* pPhysicalDeviceGroupCount, VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties)
    {
        return _vkEnumeratePhysicalDeviceGroups(instance, pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
    }
}