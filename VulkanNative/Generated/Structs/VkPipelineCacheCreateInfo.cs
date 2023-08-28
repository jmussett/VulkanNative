using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCacheCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineCacheCreateFlags Flags;
    public nuint InitialDataSize;
    public void* PInitialData;
}