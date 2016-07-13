using System.Collections.Generic;
using System.Linq;

namespace Puffermatic
{
    public class UnresolvedType : ProtoType
    {        
        public UnresolvedType(string typeName) : base(typeName)
        {                     
        }
        
            
        public override ProtoType Copy => new UnresolvedType(this.Name);        
    }
}