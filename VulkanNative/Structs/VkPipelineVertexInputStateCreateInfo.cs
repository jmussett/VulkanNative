using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineVertexInputStateCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineVertexInputStateCreateFlags Flags;
    public uint VertexBindingDescriptionCount;
    public VkVertexInputBindingDescription* PVertexBindingDescriptions;
    public uint VertexAttributeDescriptionCount;
    public VkVertexInputAttributeDescription* PVertexAttributeDescriptions;
}