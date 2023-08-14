using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowSessionCreatePrivateDataInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public uint Id;
    public uint Size;
    public void* PPrivateData;
}