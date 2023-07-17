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
    public char** ppEnabledLayerNames;
    public uint enabledExtensionCount;
    public char** ppEnabledExtensionNames;
    public VkPhysicalDeviceFeatures* pEnabledFeatures;
}