using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkD3D12FenceSubmitInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint waitSemaphoreValuesCount;
    public ulong* pWaitSemaphoreValues;
    public uint signalSemaphoreValuesCount;
    public ulong* pSignalSemaphoreValues;

    public VkD3D12FenceSubmitInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR;
    }
}