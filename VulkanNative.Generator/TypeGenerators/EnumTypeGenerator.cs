﻿using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator.Generators;

internal class EnumTypeGenerator : ITypeGenerator
{
    private readonly EnumRegistry _enumRegistry;
    private readonly IDictionary<string, VkEnums> _enumMap;
    private readonly IDictionary<string, string> _bitmaskTypeMap;

    public EnumTypeGenerator(EnumRegistry enumRegistry, VkRegistry vkRegistry)
    {
        _enumRegistry = enumRegistry;
        _enumMap = vkRegistry.Enums.ToDictionary(x => x.Name, x => x);
        _bitmaskTypeMap = vkRegistry.Types
            .Where(x => x.Category == "bitmask" && (x.BitValues is not null || x.Requires is not null))
            .ToDictionary(x => x.BitValues ?? x.Requires!, x => x.Name);
    }

    public TypeSyntax GenerateType(string typeName, VkType enumTypeDefinition)
    {
        if (!_enumMap.TryGetValue(enumTypeDefinition.NameAttribute, out var enumDefinition))
        {
            throw new InvalidOperationException($"Unable to find enum '{typeName}'");
        }

        // Replace with bitmask name if bitmask
        if (enumDefinition.Type == "bitmask" && _bitmaskTypeMap.TryGetValue(typeName, out var bitmaskName))
        {
            typeName = bitmaskName;
        }

        _enumRegistry.Enums.TryAdd(enumDefinition.Name, new EnumDefinition());
        
        _enumRegistry.Enums[enumDefinition.Name].ClrTypeName = typeName;
        _enumRegistry.Enums[enumDefinition.Name].EnumType = enumDefinition.Type;
        _enumRegistry.Enums[enumDefinition.Name].BitWidth = enumDefinition.BitWidth;
        _enumRegistry.Enums[enumDefinition.Name].Members.AddRange(enumDefinition.Enums);

        return CSharpFactory.Type(typeName);
    }
}