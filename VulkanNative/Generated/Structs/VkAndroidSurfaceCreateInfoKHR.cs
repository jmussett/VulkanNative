using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAndroidSurfaceCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkAndroidSurfaceCreateFlagsKHR flags;
    public ANativeWindow* window;

    public VkAndroidSurfaceCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR;
    }
}