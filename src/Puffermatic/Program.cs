using System;
using Antlr4.Runtime;
using Puffermatic.Grammar;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputStream = new AntlrInputStream(System.Console.In);
            var lexer=new ProtocolBuffers3Lexer(inputStream);            
            var tokens= new CommonTokenStream(lexer); 

            var parser = new ProtocolBuffers3Parser(tokens);
            var tree=parser.proto();
            Console.WriteLine(tree.ToStringTree());                                
        }
    }
}
