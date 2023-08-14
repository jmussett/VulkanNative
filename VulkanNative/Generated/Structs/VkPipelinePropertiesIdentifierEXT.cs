using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelinePropertiesIdentifierEXT
{
    public VkStructureType SType;
    public void* PNext;
    public fixed byte PipelineIdentifier[(int)VulkanApiConstants.VK_UUID_SIZE];
}