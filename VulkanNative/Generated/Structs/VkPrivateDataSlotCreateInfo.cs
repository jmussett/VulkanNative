using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPrivateDataSlotCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPrivateDataSlotCreateFlags Flags;
}