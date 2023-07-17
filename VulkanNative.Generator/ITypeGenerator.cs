using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator;

internal interface ITypeGenerator
{
    void GenerateType(VkType type);
}
