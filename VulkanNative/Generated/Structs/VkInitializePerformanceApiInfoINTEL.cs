using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkInitializePerformanceApiInfoINTEL
{
    public VkStructureType sType;
    public void* pNext;
    public void* pUserData;

    public VkInitializePerformanceApiInfoINTEL()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL;
    }
}