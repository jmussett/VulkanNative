using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkInstanceCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkInstanceCreateFlags Flags;
    public VkApplicationInfo* PApplicationInfo;
    public uint EnabledLayerCount;
    public byte** PpEnabledLayerNames;
    public uint EnabledExtensionCount;
    public byte** PpEnabledExtensionNames;
}