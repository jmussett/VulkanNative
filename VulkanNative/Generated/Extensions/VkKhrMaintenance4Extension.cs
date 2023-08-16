using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrMaintenance4Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> _vkGetDeviceBufferMemoryRequirements;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> _vkGetDeviceImageMemoryRequirements;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void> _vkGetDeviceImageSparseMemoryRequirements;

    public VkKhrMaintenance4Extension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetDeviceBufferMemoryRequirements = (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void>)loader.GetDeviceProcAddr(device, "vkGetDeviceBufferMemoryRequirements");
        _vkGetDeviceImageMemoryRequirements = (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void>)loader.GetDeviceProcAddr(device, "vkGetDeviceImageMemoryRequirements");
        _vkGetDeviceImageSparseMemoryRequirements = (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void>)loader.GetDeviceProcAddr(device, "vkGetDeviceImageSparseMemoryRequirements");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceBufferMemoryRequirements(VkDevice device, VkDeviceBufferMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
        _vkGetDeviceBufferMemoryRequirements(device, pInfo, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceImageMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
        _vkGetDeviceImageMemoryRequirements(device, pInfo, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDeviceImageSparseMemoryRequirements(VkDevice device, VkDeviceImageMemoryRequirements* pInfo, uint* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements2* pSparseMemoryRequirements)
    {
        _vkGetDeviceImageSparseMemoryRequirements(device, pInfo, pSparseMemoryRequirementCount, pSparseMemoryRequirements);
    }
}