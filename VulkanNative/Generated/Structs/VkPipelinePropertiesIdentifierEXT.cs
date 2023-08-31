using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelinePropertiesIdentifierEXT
{
    public VkStructureType sType;
    public void* pNext;
    public fixed byte pipelineIdentifier[(int)VulkanApiConstants.VK_UUID_SIZE];
}