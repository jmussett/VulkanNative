using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeatures
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 BufferDeviceAddress;
    public VkBool32 BufferDeviceAddressCaptureReplay;
    public VkBool32 BufferDeviceAddressMultiDevice;
}