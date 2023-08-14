using CSharpComposer;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VulkanNative.Generator.Registries;

namespace VulkanNative.Generator.SyntaxGenerators
{
    internal class EnumGenerator
    {
        private readonly EnumRegistry _enumRegistry;
        private readonly DocumentRegistry _documentRegistry;

        public EnumGenerator(EnumRegistry enumRegistry, DocumentRegistry documentRegistry)
        {
            _enumRegistry = enumRegistry;
            _documentRegistry = documentRegistry;
        }

        public void GenerateEnums()
        {
            foreach (var enumDefinition in _enumRegistry.Enums.Values)
            {
                /*
               - enum types with a bitwidth of 32 (or no bitwidth) will be int32_t, or an 'int' in c#
               - enum types with a bitwidth of 64 will be int64_t, or a 'long' in c#
               - bitmask types with a bitwidth of 32 (or no bitwidth) will be uint32_t, or a 'uint' in c#
               - bitmask types with a bitwidth of 64 will be uint64_t, or a 'ulong' in c#
               */

                var enumType = enumDefinition.EnumType switch
                {
                    "enum" => "int",
                    "bitmask" => enumDefinition.BitWidth == "64" ? "ulong" : "uint",
                    _ => throw new InvalidOperationException()
                };

                var compilationUnit = CSharpFactory.CompilationUnit(x => x
                    .AddFileScopedNamespaceDeclaration("VulkanNative", x =>
                        x.AddEnumDeclaration(
                            enumDefinition.ClrTypeName,
                            x =>
                            {
                                x.AddSimpleBaseType(enumType);
                                x.AddModifierToken(SyntaxKind.PublicKeyword);

                                if (enumDefinition.EnumType == "bitmask")
                                {
                                    x = x.AddAttribute("Flags");
                                }

                                if (enumDefinition.Members.Count == 0)
                                {
                                    x.AddEnumMemberDeclaration("None", x => x.WithEqualsValue("0"));
                                    return;
                                }

                                foreach (var enumMember in enumDefinition.Members.Values)
                                {
                                    if (!string.IsNullOrWhiteSpace(enumMember.Alias))
                                    {
                                        // Skip if the member is an alias
                                        continue;
                                    }

                                    // TODO: comments

                                    string enumValue;

                                    if (enumMember.Value is not null)
                                    {
                                        enumValue = enumMember.Value;
                                    }
                                    else if (enumMember.Offset is not null)
                                    {
                                        // base_value = 1000000000
                                        // range_size = 1000
                                        // enum_offset(extension_number, offset) = base_value + (extension_number - 1) × range_size + offset

                                        var offset = int.Parse(enumMember.Offset);

                                        var extensionNumber = !string.IsNullOrWhiteSpace(enumMember.Extnumber)
                                            ? int.Parse(enumMember.Extnumber)
                                            : enumDefinition.ExtensionNumber;

                                        if (extensionNumber is null)
                                        {
                                            throw new InvalidOperationException($"No extension number defined for enum member '{enumMember.Name}'");
                                        }

                                        enumValue = $"{enumMember.Dir ?? string.Empty}{1000000000 + (extensionNumber - 1) * 1000 + offset}";
                                    }
                                    else if (enumMember.Offset is not null)
                                    {
                                        // base_value = 1000000000
                                        // range_size = 1000
                                        // enum_offset(extension_number, offset) = base_value + (extension_number - 1) × range_size + offset

                                        var offset = int.Parse(enumMember.Offset);
                                        var extNumber = int.Parse(enumMember.Extnumber);

                                        enumValue = $"{1000000000 + (extNumber - 1) * 1000 + offset}";
                                    }
                                    else if (enumMember.Bitpos is not null)
                                    {
                                        enumValue = $"{(enumType == "ulong" ? "1UL" : "1U")} << {enumMember.Bitpos}";
                                    }
                                    else
                                    {
                                        throw new InvalidOperationException($"No value defined for enum member '{enumMember.Name}'");
                                    }

                                    x = enumValue is not null
                                        ? x.AddEnumMemberDeclaration(enumMember.Name, x => x.WithEqualsValue(enumValue))
                                        : x.AddEnumMemberDeclaration(enumMember.Name);
                                }
                            }
                        )
                    )
                );

                _documentRegistry.Documents.Add($"Enums/{enumDefinition.ClrTypeName}.cs", compilationUnit);
            }

        }
    }
}
