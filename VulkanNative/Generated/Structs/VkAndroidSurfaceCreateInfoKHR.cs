using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAndroidSurfaceCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkAndroidSurfaceCreateFlagsKHR flags;
    public ANativeWindow* window;
}