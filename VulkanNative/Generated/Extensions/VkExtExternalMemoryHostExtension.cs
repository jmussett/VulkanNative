using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtExternalMemoryHostExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, void*, VkMemoryHostPointerPropertiesEXT*, VkResult> _vkGetMemoryHostPointerPropertiesEXT;

    public VkExtExternalMemoryHostExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetMemoryHostPointerPropertiesEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, void*, VkMemoryHostPointerPropertiesEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetMemoryHostPointerPropertiesEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties)
    {
        return _vkGetMemoryHostPointerPropertiesEXT(device, handleType, pHostPointer, pMemoryHostPointerProperties);
    }
}