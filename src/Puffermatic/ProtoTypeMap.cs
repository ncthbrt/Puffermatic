using System.Collections.Generic;
using System.Linq;

namespace Puffermatic
{
    public class ProtoTypeMap{          
        public IDictionary<string,ProtoType> Types;
        public IDictionary<string,ProtoType> UnresolvedTypes;
        public string PackageName{get;}
        public ProtoTypeMap(string packageName){
            PackageName=packageName;
            Types=new Dictionary<string, ProtoType>();
        }
        public ProtoTypeMap(string packageName, ProtoType type):this(packageName){
            Types.Add(type.Name,type);
        }

        public ProtoTypeMap(string packageName, ProtoType type, ProtoTypeMap childTypes):this(packageName){
            Types.Add(type.Name,type);
            
            foreach (var child in childTypes.Types.Values.Select(x=>x.Copy).ToList())
            {                                        

                child.Name=type.Name+"."+child.Name;
                Types.Add(child.Name,child);                    
            }
        }
    }
}