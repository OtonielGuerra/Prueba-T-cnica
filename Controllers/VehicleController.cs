using System;
using System.Collections.Generic;
using Jonathan_Guerra.Models;
using Jonathan_Guerra.Interfaces;
using static Jonathan_Guerra.Util.Printer;
using static System.Console;

namespace Jonathan_Guerra.Controllers
{
    public class VehicleController : IBinnacle
    {
        private List<Vehicle> VehicleList = new List<Vehicle>();
        

        public void add(object element)
        {
            this.VehicleList.Add((Vehicle)element);
        }

        public void update(object element)
        {
            
        }

        public void delete(object element)
        {
            this.VehicleList.Remove((Vehicle)element);
        }

        public object search(string id)
        {
            Vehicle result = null;
            foreach(var item in VehicleList)
            {
                if(item.Id.Equals(id, StringComparison.Ordinal))
                {
                    result = item;
                    break;
                }
            }
            return (object)result;
        }

        public void find()
        {
            WriteTitle("Listado de vehículos");
            foreach (var item in VehicleList)
            {
                WriteLine(item);
            }
        }

        public void ShowDetail(string type)
        {
            WriteTitle("Listado de Aviones");
            foreach (var item in VehicleList)
            {
                switch (type)
                {
                    case "Plane":
                        if(item.GetType().ToString() == "Jonathan_Guerra.Models.Plane")
                        {
                            WriteLine((Plane)item);
                        }
                        break;
                    case "Submarine":
                        if(item.GetType().ToString() == "Jonathan_Guerra.Models.Submarine")
                        {
                            WriteLine((Submarine)item);
                        }
                        break;
                    default:
                    break;
                }
            }
        }
    }
}