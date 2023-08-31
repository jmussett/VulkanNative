using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtMetalObjectsExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkExportMetalObjectsInfoEXT*, void> _vkExportMetalObjectsEXT;

    public VkExtMetalObjectsExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkExportMetalObjectsEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkExportMetalObjectsInfoEXT*, void>)loader.GetDeviceProcAddr(device, "vkExportMetalObjectsEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkExportMetalObjectsEXT(VkDevice device, VkExportMetalObjectsInfoEXT* pMetalObjectsInfo)
    {
        _vkExportMetalObjectsEXT(device, pMetalObjectsInfo);
    }
}