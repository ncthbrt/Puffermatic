namespace Puffermatic
{
    public abstract class ProtoType{
        public string Name{get; set;}
        
        public ProtoType(string typeName){
            Name=typeName;
        }
        public abstract ProtoType Copy{ get;}
    }   
}