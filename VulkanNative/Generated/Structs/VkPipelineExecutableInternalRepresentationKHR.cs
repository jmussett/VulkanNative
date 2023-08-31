using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineExecutableInternalRepresentationKHR
{
    public VkStructureType sType;
    public void* pNext;
    public fixed byte name[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed byte description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public VkBool32 isText;
    public nuint dataSize;
    public void* pData;
}