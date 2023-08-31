using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProtectedMemoryProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 protectedNoFault;

    public VkPhysicalDeviceProtectedMemoryProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_PROPERTIES;
    }
}