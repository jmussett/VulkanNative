using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowSessionCreatePrivateDataInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint id;
    public uint size;
    public void* pPrivateData;
}