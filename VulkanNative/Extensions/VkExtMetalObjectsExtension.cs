using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtMetalObjectsExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkExportMetalObjectsInfoEXT*, void> _vkExportMetalObjectsEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkExportMetalObjectsEXT(VkDevice device, VkExportMetalObjectsInfoEXT* pMetalObjectsInfo)
    {
        _vkExportMetalObjectsEXT(device, pMetalObjectsInfo);
    }
}