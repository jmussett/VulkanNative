using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator;

internal interface ITypeGenerator
{
    TypeSyntax GenerateType(VkType type);
}
