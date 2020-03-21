namespace Jonathan_Guerra.Models
{
    public class Submarine : Vehicle
    {
        public float MaximumDeep { get; set; }

        public Submarine() : base()
        {
            
        }
        public Submarine(float maximumDeep, float maximumSpeed, float minimumSpeed, string brand, string model) : 
            base(maximumSpeed, minimumSpeed, brand, model)
        {
            this.MaximumDeep = maximumDeep;
        }

        public void Immers(float meters)
        {
            this.MaximumDeep += meters;
        }

        public override string ToString()
        {
            return $"{{\"Id\" : \"{this.Id}\", \"Modelo\" : \"{this.Model}\", "+
                $"\"Marca\" : \"{this.Brand}\", \"Profundidad Máxima\" : \"{this.MaximumDeep}\", "+
                $"\"Tipo\" : \"{this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf(".") + 1)}\"}}";
        }
    }
}