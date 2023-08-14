using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoProfileListInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint ProfileCount;
    public VkVideoProfileInfoKHR* PProfiles;
}