using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VulkanNative.Generator.Builder.Builders;

public static class WhileStatementBuilder
{

    public static WhileStatementSyntax CreateWhileLoopSyntax(Action<IExpressionBuilder> expressionCallback, Func<IBlockBuilder, IBlockBuilder> blockCallback)
    {
        var expressionSyntax = ExpressionBuilder.CreateSyntax(expressionCallback);

        var blockSyntax = BlockBuilder.CreateSyntax(blockCallback);

        var whileStatementSyntax = SyntaxFactory.WhileStatement(
            expressionSyntax,
            blockSyntax
        );
        return whileStatementSyntax;
    }
}