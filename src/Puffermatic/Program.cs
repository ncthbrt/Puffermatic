using System;
using Antlr4.Runtime;
using Puffermatic.Grammar;

namespace Puffermatic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var text=
@"// version 0.1.0

syntax = 'proto3';
package geo_json;

import 'geo_json/geometry_collection.proto';
import 'geo_json/coordinate_reference_system.proto';
import 'geo_json/json.proto';

message Feature {
    repeated GeometryObject geometries=1;
    string id=2;
    JsonObject properties=3;    
    CoordinateReferenceSystem crs=4;
    repeated double bbox=5;    
}
";
            var inputStream = new AntlrInputStream(text);
            var lexer=new ProtocolBuffers3Lexer(inputStream);            
            var tokens= new CommonTokenStream(lexer); 
            var parser = new ProtocolBuffers3Parser(tokens);

            var tree=parser.proto();
            var packageVisitor=new PackageVisitor();
            var result=packageVisitor.Visit(tree);
            if(result!=null){
                Console.WriteLine($"{result}");
            }else{
                Console.WriteLine($"No package");
            }            
        }
    }
}
