using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceCreateFlags flags;
    public uint queueCreateInfoCount;
    public VkDeviceQueueCreateInfo* pQueueCreateInfos;
    public uint enabledLayerCount;
    public byte** ppEnabledLayerNames;
    public uint enabledExtensionCount;
    public byte** ppEnabledExtensionNames;
    public VkPhysicalDeviceFeatures* pEnabledFeatures;
}