using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceBufferMemoryRequirements
{
    public VkStructureType SType;
    public void* PNext;
    public VkBufferCreateInfo* PCreateInfo;
}