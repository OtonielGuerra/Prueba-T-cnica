using System;
using Jonathan_Guerra.Interfaces;

namespace Jonathan_Guerra.Models
{
    public abstract class Vehicle : IBinnacle
    {
        public string Id { get; set; }
        public float MaximumSpeed { get; set; }
        public float MinimumSpeed { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {
            this.Id = GenerarID();
        }

        public Vehicle(float maximumSpeed, float minimumSpeed, string brand, string model)
        {
            this.Id = GenerarID();
            this.MaximumSpeed = maximumSpeed;
            this.MinimumSpeed = minimumSpeed;
            this.Brand = brand;
            this.Model = model;
        }

        private string GenerarID()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

        public void TurnOn()
        {

        }

        public void TurnOff()
        {

        }

        public void add(object elemento)
        {
            throw new NotImplementedException();
        }

        public void update(object elemento)
        {
            throw new NotImplementedException();
        }

        public void delete(object elemento)
        {
            throw new NotImplementedException();
        }

        public object search(string id)
        {
            throw new NotImplementedException();
        }

        public void find()
        {
            throw new NotImplementedException();
        }

        public void ShowDetail(string type)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{{\"Id\" : \"{this.Id}\", \"Velocidad Máximo\" : \"{this.MaximumSpeed}\", "+
                $"\"Velocidad Mínima\" : \"{this.MinimumSpeed}\", \"Marca\" : \"{this.Brand}\", "+
                $"\"Modelo\" : \"{this.Model}\", " +
                $"\"Tipo\" : \"{this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf(".") + 1)}\"}}";
        }
    }
}