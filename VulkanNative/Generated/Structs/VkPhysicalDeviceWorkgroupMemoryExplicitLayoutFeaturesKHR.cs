using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 WorkgroupMemoryExplicitLayout;
    public VkBool32 WorkgroupMemoryExplicitLayoutScalarBlockLayout;
    public VkBool32 WorkgroupMemoryExplicitLayout8BitAccess;
    public VkBool32 WorkgroupMemoryExplicitLayout16BitAccess;
}