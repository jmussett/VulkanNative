using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registry;
using static System.Net.Mime.MediaTypeNames;

namespace VulkanNative.Generator.Generators;

internal class FuncPointerGenerator : ITypeGenerator
{
    private readonly TypeLocator _typeLocator;

    public FuncPointerGenerator(TypeLocator typeLocator)
    {
        _typeLocator = typeLocator;
    }

    public TypeSyntax GenerateType(string _, VkType funcPointerDefinition)
    {
        return CSharpFactory.Type(x => x.AsFunctionPointerType(x =>
        {
            x.WithCallingConvention(
                FunctionPointerCallingConventionManagedOrUnmanagedKeyword.UnmanagedKeyword,
                x => x.AddFunctionPointerUnmanagedCallingConvention("Cdecl")
            );

            for(var i = 0; i < funcPointerDefinition.Types.Count; i++)
            {
                var type = funcPointerDefinition.Types[i];
                var postTypeData = funcPointerDefinition.TextEntries[i + 2]
                    .Substring(0, funcPointerDefinition.TextEntries[i + 2].IndexOf(' '));

                x.AddFunctionPointerParameter(
                    x => x.FromSyntax(_typeLocator.LookupType(type, postTypeData))
                );
            }

            // TODO: parse return type.
            x.AddFunctionPointerParameter(
                x => x.AsPredefinedType(PredefinedTypeKeyword.VoidKeyword)
            );
        }));
    }
}
