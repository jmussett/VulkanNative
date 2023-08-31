using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 accelerationStructure;
    public VkBool32 accelerationStructureCaptureReplay;
    public VkBool32 accelerationStructureIndirectBuild;
    public VkBool32 accelerationStructureHostCommands;
    public VkBool32 descriptorBindingAccelerationStructureUpdateAfterBind;

    public VkPhysicalDeviceAccelerationStructureFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR;
    }
}