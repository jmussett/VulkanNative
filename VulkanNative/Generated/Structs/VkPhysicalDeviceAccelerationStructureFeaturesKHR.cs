using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 AccelerationStructure;
    public VkBool32 AccelerationStructureCaptureReplay;
    public VkBool32 AccelerationStructureIndirectBuild;
    public VkBool32 AccelerationStructureHostCommands;
    public VkBool32 DescriptorBindingAccelerationStructureUpdateAfterBind;
}