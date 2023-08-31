using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 workgroupMemoryExplicitLayout;
    public VkBool32 workgroupMemoryExplicitLayoutScalarBlockLayout;
    public VkBool32 workgroupMemoryExplicitLayout8BitAccess;
    public VkBool32 workgroupMemoryExplicitLayout16BitAccess;
}