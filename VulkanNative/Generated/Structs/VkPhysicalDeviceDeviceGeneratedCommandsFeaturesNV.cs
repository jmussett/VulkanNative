using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 deviceGeneratedCommands;

    public VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV;
    }
}