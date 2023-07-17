﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VulkanNative.Generator.Registries;

internal class DocumentRegistry
{
    public Dictionary<string, CompilationUnitSyntax> Documents { get; } = new();
}
