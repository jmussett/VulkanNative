using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkInstanceCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkInstanceCreateFlags flags;
    public VkApplicationInfo* pApplicationInfo;
    public uint enabledLayerCount;
    public byte** ppEnabledLayerNames;
    public uint enabledExtensionCount;
    public byte** ppEnabledExtensionNames;
}