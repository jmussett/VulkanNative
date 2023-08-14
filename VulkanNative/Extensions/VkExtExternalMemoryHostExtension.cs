using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtExternalMemoryHostExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, void*, VkMemoryHostPointerPropertiesEXT*, VkResult> _vkGetMemoryHostPointerPropertiesEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetMemoryHostPointerPropertiesEXT(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties)
    {
        return _vkGetMemoryHostPointerPropertiesEXT(device, handleType, pHostPointer, pMemoryHostPointerProperties);
    }
}