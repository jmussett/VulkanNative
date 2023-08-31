using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandPoolCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkCommandPoolCreateFlags flags;
    public uint queueFamilyIndex;
}