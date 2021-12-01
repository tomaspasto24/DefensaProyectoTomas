namespace Ucu.Poo.Defense
{
    public class Material
    {
        public string Name { get; set; }

        public MaterialType Type { get; set; }

        public bool IsDangerous
        {
            get
            {
                return this.Type.IsDangerous;
            }
        }

        public Material(string name, MaterialType type)
        {
            this.Name = name;
            this.Type = type;
        }
    }
}