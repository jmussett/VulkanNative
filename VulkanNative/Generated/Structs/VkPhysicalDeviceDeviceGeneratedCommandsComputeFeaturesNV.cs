using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 deviceGeneratedCompute;
    public VkBool32 deviceGeneratedComputePipelines;
    public VkBool32 deviceGeneratedComputeCaptureReplay;

    public VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_COMPUTE_FEATURES_NV;
    }
}