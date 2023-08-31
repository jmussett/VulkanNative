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

    public VkOpticalFlowSessionCreatePrivateDataInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_PRIVATE_DATA_INFO_NV;
    }
}