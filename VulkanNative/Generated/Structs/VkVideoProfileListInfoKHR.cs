using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoProfileListInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint profileCount;
    public VkVideoProfileInfoKHR* pProfiles;
}