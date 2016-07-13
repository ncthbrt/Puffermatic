using Puffermatic.Grammar;
using System.Linq;
using System;
namespace Puffermatic
{
    public class PackageVisitor : ProtocolBuffers3BaseVisitor<string>
    {
        public override string VisitProto(ProtocolBuffers3Parser.ProtoContext context)
        {
            if (context.children.Where(x => x is ProtocolBuffers3Parser.PackageContext).Count() > 1)
            {
                context.children.Where(x => x is ProtocolBuffers3Parser.PackageContext).Select(x => Visit(x));
                throw new Exception("File cannot contain two package declarations");
            }
            return Visit(context.package(0));
        }
        public override string VisitPackage(ProtocolBuffers3Parser.PackageContext context)
        {
            var identifier = context.Identifier()?.GetText();
            var fullIdentifier = context.FullIdentifier()?.GetText();
            return identifier ?? fullIdentifier;
        }
    }
}