using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAndroidSurfaceCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkAndroidSurfaceCreateFlagsKHR Flags;
    public ANativeWindow* Window;
}