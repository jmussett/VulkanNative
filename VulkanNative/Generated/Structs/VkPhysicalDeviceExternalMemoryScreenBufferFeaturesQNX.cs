using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 screenBufferImport;

    public VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_SCREEN_BUFFER_FEATURES_QNX;
    }
}