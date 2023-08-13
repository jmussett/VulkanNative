using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 DeviceGeneratedCompute;
    public VkBool32 DeviceGeneratedComputePipelines;
    public VkBool32 DeviceGeneratedComputeCaptureReplay;
}