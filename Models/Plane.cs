namespace Jonathan_Guerra.Models
{
    public class Plane : Vehicle
    {
        public float MaximumHeight { get; set; }
        public float MinimumHeight { get; set; }

        public Plane() : base()
        {
            
        }

        public Plane(float maximumHeight, float minimumHeight, float maximumSpeed, 
            float minimumSpeed, string brand, string model) : 
                base(maximumSpeed, minimumSpeed, brand, model)
        {
            this.MaximumHeight = maximumHeight;
            this.MinimumHeight = minimumHeight;
        }

        public void TakeOff()
        {

        }

        public void ToLand()
        {

        }

        public void DecreaseHeight(float pie)
        {
            this.MaximumHeight -= pie;
        }
        public override string ToString()
        {
            return $"{{\"Id\" : \"{this.Id}\", \"Modelo\" : \"{this.Model}\", "+
                $"\"Marca\" : \"{this.Brand}\", \"Altura Máxima\" : \"{this.MaximumHeight}\", "+
                $"\"Altura Mínima\" : \"{this.MinimumHeight}\", " +
                $"\"Tipo\" : \"{this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf(".") + 1)}\"}}";
        }
    }
}