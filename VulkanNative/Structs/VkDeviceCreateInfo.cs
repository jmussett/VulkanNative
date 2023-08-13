using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceCreateFlags Flags;
    public uint QueueCreateInfoCount;
    public VkDeviceQueueCreateInfo* PQueueCreateInfos;
    public uint EnabledLayerCount;
    public char** PpEnabledLayerNames;
    public uint EnabledExtensionCount;
    public char** PpEnabledExtensionNames;
    public VkPhysicalDeviceFeatures* PEnabledFeatures;
}