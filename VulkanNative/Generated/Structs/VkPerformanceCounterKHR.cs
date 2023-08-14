using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceCounterKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkPerformanceCounterUnitKHR Unit;
    public VkPerformanceCounterScopeKHR Scope;
    public VkPerformanceCounterStorageKHR Storage;
    public fixed byte Uuid[(int)VulkanApiConstants.VK_UUID_SIZE];
}