using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCacheCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCacheCreateFlags flags;
    public nuint initialDataSize;
    public void* pInitialData;

    public VkPipelineCacheCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO;
    }
}