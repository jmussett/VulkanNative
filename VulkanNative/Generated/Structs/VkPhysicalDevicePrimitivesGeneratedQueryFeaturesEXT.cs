using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 primitivesGeneratedQuery;
    public VkBool32 primitivesGeneratedQueryWithRasterizerDiscard;
    public VkBool32 primitivesGeneratedQueryWithNonZeroStreams;

    public VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT;
    }
}