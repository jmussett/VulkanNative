using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineColorWriteCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint attachmentCount;
    public VkBool32* pColorWriteEnables;
}