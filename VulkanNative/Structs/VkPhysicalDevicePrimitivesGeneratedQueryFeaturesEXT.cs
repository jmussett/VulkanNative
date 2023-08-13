using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 PrimitivesGeneratedQuery;
    public VkBool32 PrimitivesGeneratedQueryWithRasterizerDiscard;
    public VkBool32 PrimitivesGeneratedQueryWithNonZeroStreams;
}