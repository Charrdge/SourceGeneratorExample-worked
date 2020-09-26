using System.Text;
using Microsoft.CodeAnalysis;

namespace Modular
{
    [Generator]
    public class ModularGenerator : ISourceGenerator
    {
        private const string SOURCE = @"
using System;

namespace Mod
{
    public static class Cls
    {
        public static void SayHello() => Console.WriteLine(""Fuck You"");
    }
}";

        public void Execute(GeneratorExecutionContext context) => context.AddSource("mod", Microsoft.CodeAnalysis.Text.SourceText.From(SOURCE, Encoding.UTF8));

        public void Initialize(GeneratorInitializationContext context) { }
    }
}