using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalBufferProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalMemoryProperties externalMemoryProperties;

    public VkExternalBufferProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES;
    }
}