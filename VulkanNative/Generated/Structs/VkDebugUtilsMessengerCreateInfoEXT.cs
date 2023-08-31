using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDebugUtilsMessengerCreateFlagsEXT flags;
    public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
    public VkDebugUtilsMessageTypeFlagsEXT messageType;
    public delegate* unmanaged[Cdecl]<VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void*, void> pfnUserCallback;
    public void* pUserData;
}