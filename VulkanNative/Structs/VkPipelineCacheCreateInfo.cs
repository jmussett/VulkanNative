using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCacheCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCacheCreateFlags flags;
    public nint initialDataSize;
    public void* pInitialData;
}