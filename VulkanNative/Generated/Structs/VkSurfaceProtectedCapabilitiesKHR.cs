using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSurfaceProtectedCapabilitiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 supportsProtected;

    public VkSurfaceProtectedCapabilitiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR;
    }
}