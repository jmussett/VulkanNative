using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize minImportedHostPointerAlignment;
}