﻿using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using VulkanNative.Generator.Generators;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator;

internal class TypeLocator
{
    private readonly VkRegistry _vkRegistry;
    private readonly TypeRegistry _typeRegistry;
    private readonly TypeGeneratorRegistry _generatorRegistry;

    public TypeLocator(VkRegistry vkRegistry, TypeRegistry typeRegistry, TypeGeneratorRegistry generatorRegistry)
    {
        _vkRegistry = vkRegistry;
        _typeRegistry = typeRegistry;
        _generatorRegistry = generatorRegistry;
    }

    public TypeSyntax LookupType(string type, string? postTypeData = null)
    {
        if (type == "void" && string.IsNullOrEmpty(postTypeData))
        {
            return CSharpFactory.Type(x => x.AsPredefinedType(PredefinedTypeKeyword.VoidKeyword));
        }

        var pointerRank = postTypeData?.Count(c => c == '*') ?? 0;

        if (pointerRank > 0)
        {
            return CSharpFactory.Type(x => BuildPointerType(x, type, pointerRank));
        }

        if (_typeRegistry.Types.TryGetValue(type, out var typeSyntax))
        {
            return typeSyntax;
        }

        var vkType = _vkRegistry.Types.FirstOrDefault(x => x.Name == type)
            ?? _vkRegistry.Types.FirstOrDefault(x => x.NameAttribute == type)
            ?? throw new InvalidOperationException($"Unable to find type '{type}'");

        typeSyntax = _generatorRegistry.GenerateType(vkType);

        _typeRegistry.Types.TryAdd(type, typeSyntax);

        return typeSyntax;
    }

    private void BuildPointerType(ITypeBuilder typeBuilder, string typeName, int pointerRank)
    {
        if (pointerRank == 0)
        {
            typeBuilder.FromSyntax(LookupType(typeName, null));
        }
        else
        {
            typeBuilder.AsPointerType(x => BuildPointerType(x, typeName, pointerRank - 1));
        }
    }
}
