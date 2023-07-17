using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFaultData
{
    public VkStructureType sType;
    public void* pNext;
    public VkFaultLevel faultLevel;
    public VkFaultType faultType;
}