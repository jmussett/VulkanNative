using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferConstraintsInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferCreateInfo createInfo;
    public VkFormatFeatureFlags requiredFormatFeatures;
    public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;

    public VkBufferConstraintsInfoFUCHSIA()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA;
    }
}