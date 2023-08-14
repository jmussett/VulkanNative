using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferConstraintsInfoFUCHSIA
{
    public VkStructureType SType;
    public void* PNext;
    public VkBufferCreateInfo CreateInfo;
    public VkFormatFeatureFlags RequiredFormatFeatures;
    public VkBufferCollectionConstraintsInfoFUCHSIA BufferCollectionConstraints;
}