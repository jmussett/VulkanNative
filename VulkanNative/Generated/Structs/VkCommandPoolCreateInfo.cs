using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandPoolCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkCommandPoolCreateFlags Flags;
    public uint QueueFamilyIndex;
}