using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceInvocationMaskFeaturesHUAWEI
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 invocationMask;

    public VkPhysicalDeviceInvocationMaskFeaturesHUAWEI()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INVOCATION_MASK_FEATURES_HUAWEI;
    }
}