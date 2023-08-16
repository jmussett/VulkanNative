using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvExternalMemoryRdmaExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetRemoteAddressInfoNV*, VkRemoteAddressNV*, VkResult> _vkGetMemoryRemoteAddressNV;

    public VkNvExternalMemoryRdmaExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetMemoryRemoteAddressNV = (delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetRemoteAddressInfoNV*, VkRemoteAddressNV*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetMemoryRemoteAddressNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetMemoryRemoteAddressNV(VkDevice device, VkMemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, VkRemoteAddressNV* pAddress)
    {
        return _vkGetMemoryRemoteAddressNV(device, pMemoryGetRemoteAddressInfo, pAddress);
    }
}