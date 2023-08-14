using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;
using VulkanNative.Generator.VulkanRegistry;

namespace VulkanNative.Generator.Generators;

internal class EnumTypeGenerator : ITypeGenerator
{
    private readonly VulkanApiRegistry _vulkanRegistry;
    private readonly EnumRegistry _enumRegistry;

    public EnumTypeGenerator(VulkanApiRegistry vulkanRegistry, EnumRegistry enumRegistry)
    {
        _vulkanRegistry = vulkanRegistry;
        _enumRegistry = enumRegistry;
    }

    public TypeSyntax GenerateType(string typeName, VkType enumTypeDefinition)
    {
        // TODO: Cache?
        var enumMap = _vulkanRegistry.Root.Enums.ToDictionary(x => x.Name, x => x);

        var aliasMap = _vulkanRegistry.Root.Types
            .Where(x => x.Category == "enum" && x.Alias is not null)
            .ToDictionary(x => x.NameAttribute, x => x.Alias);

        var bitmaskTypeMap = _vulkanRegistry.Root.Types
            .Where(x => x.Category == "bitmask" && (x.BitValues is not null || x.Requires is not null))
            .ToDictionary(x => x.BitValues ?? x.Requires!, x => x.Name);

        var enumName = enumTypeDefinition.NameAttribute;

        if (aliasMap.TryGetValue(enumName, out var aliasName))
        {
            enumName = aliasName;
        }

        if (!enumMap.TryGetValue(enumName, out var enumDefinition))
        {
            throw new InvalidOperationException($"Unable to find enum '{typeName}'");
        }

        // Replace with bitmask name if bitmask
        if (enumDefinition.Type == "bitmask" && bitmaskTypeMap.TryGetValue(typeName, out var bitmaskName))
        {
            typeName = bitmaskName;
        }

        _enumRegistry.Enums.TryAdd(enumDefinition.Name, new EnumDefinition());
        
        _enumRegistry.Enums[enumDefinition.Name].ClrTypeName = typeName;
        _enumRegistry.Enums[enumDefinition.Name].EnumType = enumDefinition.Type;
        _enumRegistry.Enums[enumDefinition.Name].BitWidth = enumDefinition.BitWidth;
        
        foreach(var enumMember in enumDefinition.Enums)
        {
            _enumRegistry.Enums[enumDefinition.Name].Members[enumMember.Name] = enumMember;
        }

        return CSharpFactory.Type(typeName);
    }
}
