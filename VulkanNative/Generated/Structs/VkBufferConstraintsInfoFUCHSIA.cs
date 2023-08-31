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
}