using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 bufferDeviceAddress;
    public VkBool32 bufferDeviceAddressCaptureReplay;
    public VkBool32 bufferDeviceAddressMultiDevice;

    public VkPhysicalDeviceBufferDeviceAddressFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES;
    }
}