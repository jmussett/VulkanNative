using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineColorWriteCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint AttachmentCount;
    public VkBool32* PColorWriteEnables;
}