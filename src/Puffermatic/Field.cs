namespace Puffermatic
{
    public class Field
    {        
        public Field Copy{
            get
            {
                var field=new Field();
                field.UnresolvedType=UnresolvedType;
                field.Name=Name;
                field.Number=Number;
                field.Type=Type;
                return field;
            }
        }

        public string UnresolvedType {get; set;}
        public ProtoType Type {get; set;}
        public uint Number {get; set;}
        public string Name{ get; set; }
    }
}