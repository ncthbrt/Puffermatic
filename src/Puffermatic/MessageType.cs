using System.Collections.Generic;
using System.Linq;

namespace Puffermatic
{
    public class MessageType : ProtoType
    {
        public IList<Field> Fields{ get; }
        public MessageType(string typeName) : base(typeName)
        {
            Fields=new List<Field>();            
        }

        public MessageType(string typeName, IList<Field> fields): base(typeName)
        {
            Fields=fields;            
        }
        public override ProtoType Copy => new MessageType(this.Name,this.Fields.Select(x=>x.Copy).ToList());        
    }
}