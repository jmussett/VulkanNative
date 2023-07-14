using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VulkanNative.Generator.Builder.Builders;

public static class DoStatementBuilder
{

    public static DoStatementSyntax CreateSyntax(Func<IBlockBuilder, IBlockBuilder> blockCallback, Action<IExpressionBuilder> expressionCallback)
    {
        var blockSyntax = BlockBuilder.CreateSyntax(blockCallback);

        var expressionSyntax = ExpressionBuilder.CreateSyntax(expressionCallback);

        return SyntaxFactory.DoStatement(
            blockSyntax,
            expressionSyntax
        );
    }
}