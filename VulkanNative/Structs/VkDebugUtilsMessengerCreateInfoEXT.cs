using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDebugUtilsMessengerCreateFlagsEXT Flags;
    public VkDebugUtilsMessageSeverityFlagsEXT MessageSeverity;
    public VkDebugUtilsMessageTypeFlagsEXT MessageType;
    public delegate* unmanaged[Cdecl]<VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void*, void> PfnUserCallback;
    public void* PUserData;
}