﻿using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Generators;

internal class BitMaskTypeGenerator : ITypeGenerator
{
    private readonly TypeLocator _typeLocator;
    private readonly DocumentRegistry _documentRegistry;

    public BitMaskTypeGenerator(TypeLocator typeLocator, DocumentRegistry documentRegistry)
    {
        _typeLocator = typeLocator;
        _documentRegistry = documentRegistry;
    }

    public TypeSyntax GenerateType(string typeName, VkType bitmaskDefinition)
    {
        if (!string.IsNullOrEmpty(bitmaskDefinition.Alias))
        {
            return _typeLocator.LookupType(bitmaskDefinition.Alias);
        }

        if (!string.IsNullOrEmpty(bitmaskDefinition.Requires))
        {
            return _typeLocator.LookupType(bitmaskDefinition.Requires);
        }

        if (!string.IsNullOrEmpty(bitmaskDefinition.BitValues))
        {
            return _typeLocator.LookupType(bitmaskDefinition.BitValues);
        }

        // Bitmask does not have any enumerations, create an empty bitmask enum

        var compilationUnit = CSharpFactory.CompilationUnit(x => x
            .AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                x.AddEnumDeclaration(
                    typeName,
                    x => x
                        .AddSimpleBaseType("uint")
                        .AddModifierToken(SyntaxKind.PublicKeyword)
                        .AddAttribute("Flags")
                        .AddEnumMemberDeclaration("None", x => x.WithEqualsValue("1U << 0"))
                )
            )
        );

        _documentRegistry.Documents.Add($"Generated/Enums/{typeName}.cs", compilationUnit);

        return CSharpFactory.Type(typeName);
    }
}