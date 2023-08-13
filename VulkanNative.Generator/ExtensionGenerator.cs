using CSharpComposer;
using Humanizer;
using Microsoft.CodeAnalysis.CSharp;
using VulkanNative.Generator.Registries;
using VulkanNative.Generator.Registry;

namespace VulkanNative.Generator;

internal class ExtensionGenerator
{
    private readonly VkRegistry _vkRegistry;
    private readonly DocumentRegistry _documentRegistry;
    private readonly CommandGenerator _commandGenerator;
    private readonly TypeLocator _typeLocator;
    private readonly EnumRegistry _enumRegistry;

    private readonly IReadOnlyDictionary<string, VkCommand> _commandLookup;
    private readonly IReadOnlyDictionary<string, VkType> _handleLookup;

    public ExtensionGenerator(VkRegistry vkRegistry, DocumentRegistry documentRegistry, CommandGenerator commandGenerator, TypeLocator typeLocator, EnumRegistry enumRegistry)
    {
        _vkRegistry = vkRegistry;
        _documentRegistry = documentRegistry;
        _commandGenerator = commandGenerator;
        _typeLocator = typeLocator;
        _enumRegistry = enumRegistry;
        _commandLookup = vkRegistry.CreateCommandLookup();
        _handleLookup = vkRegistry.CreateHandleLookup();
    }

    public void GenerateExtensions()
    {
        foreach (var extension in _vkRegistry.Extensions)
        {
            // Skip non-vulkan features (i.e: Vulkan sc, deprecated, obsolete, or provisional)
            if (!extension.Supported.Split(',').Contains("vulkan") ||
                extension.Provisional == "true" ||
                //!string.IsNullOrWhiteSpace(extension.PromotedTo) ||
                !string.IsNullOrWhiteSpace(extension.DeprecatedBy) ||
                !string.IsNullOrWhiteSpace(extension.ObsoletedBy)
                )
            {
                continue;
            }

            foreach (var requires in extension.Requires)
            {
                foreach (var type in requires.Types)
                {
                    var vkType = _vkRegistry.Types.FirstOrDefault(x => x.Name == type.NameAttribute)
                        ?? _vkRegistry.Types.FirstOrDefault(x => x.NameAttribute == type.NameAttribute)
                        ?? throw new InvalidOperationException($"Unable to find type '{type.NameAttribute}'");

                    if (vkType.Category != "include" && vkType.Category != "define")
                    {
                        // Will do a type lookup and register the type if it hasn't been registered already
                        _ = _typeLocator.LookupType(type.NameAttribute);
                    }
                }

                foreach (var enumMember in requires.Enums)
                {
                    if (enumMember.Extends is null)
                    {
                        continue;
                    }

                    _enumRegistry.Enums.TryAdd(enumMember.Extends, new EnumDefinition());

                    _enumRegistry.Enums[enumMember.Extends].ExtensionNumber = int.Parse(extension.Number!);
                    _enumRegistry.Enums[enumMember.Extends].Members[enumMember.Name] = enumMember;
                }


                //foreach (var command in requires.Commands)
                //{
                //    if (!_commandLookup.TryGetValue(command.Name, out var commandDefinition))
                //    {
                //        throw new InvalidOperationException($"Unable to find command definition '{command.Name}'");
                //    }

                //    var functionName = commandDefinition.Proto.Name;
                //    var firstParamType = commandDefinition.Params.FirstOrDefault()?.Type;

                    
                //}
            }

            var extensionClassName = $"{extension.Name.ToLowerInvariant().Pascalize()}Extension";

            var compilationUnit = CSharpFactory.CompilationUnit(x => x
                .AddFileScopedNamespaceDeclaration("VulkanNative", x => x
                    .AddClassDeclaration(extensionClassName, x =>
                    {
                    })
                )
            );

            _documentRegistry.Documents.Add($"Extensions/{extensionClassName}.cs", compilationUnit);
        }
    }
}