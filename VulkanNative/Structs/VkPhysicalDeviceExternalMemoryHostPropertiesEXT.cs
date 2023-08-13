using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceSize MinImportedHostPointerAlignment;
}