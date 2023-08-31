using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 localDimmingSupport;

    public VkDisplayNativeHdrSurfaceCapabilitiesAMD()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD;
    }
}