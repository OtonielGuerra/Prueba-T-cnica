using static Jonathan_Guerra.Util.Printer;
using static System.Console;
using System;
using Jonathan_Guerra.Controllers;
using Jonathan_Guerra.Models;

namespace Jonathan_Guerra.Menu
{
    public class MainMenu
    {
        private VehicleController controller = new VehicleController();
        public void ViewMenu()
        {
            try
            {
                byte opcion = 0;
                do
                {
                    Clear();
                    WriteTitle("Administrar Vehículos");
                    WriteLine("1. Agregar");
                    WriteLine("2. Eliminar");
                    WriteLine("3. Buscar");
                    WriteLine("4. Listar");
                    WriteLine("0. Salir");
                    WriteLine("Ingrese una opción");
                    string respuesta = ReadLine();
                    opcion = Convert.ToByte(respuesta);
                    switch(opcion)
                    {
                        case 1:
                            AddVehicle();
                            break;
                        case 2:
                            Delete();
                            break;
                        case 3:
                            SearchID();
                            break;
                        case 4:
                            ListVehicle();
                            break;
                        case 0:
                            break;
                        default:
                            WriteLine("No existe la opción");
                            break;
                    }
                }while(opcion != 0);
            }
            catch(Exception e)
            {
                WriteLine(e.Message);
            }
        }

        private void AddVehicle()
        {
            WriteTitle("Tipo de Vehículo");
            WriteLine("1. Avión");
            WriteLine("2. Submarino");
            WriteLine("0. Salir");
            WriteLine("Seleccione una opción ==> ");
            string respuesta = ReadLine();
            if(respuesta.Equals("1"))
            {
                Vehicle plane = new Plane();
                AddElement(plane);
            }
            else if(respuesta.Equals("2"))
            {
                Vehicle submarine = new Submarine();
                AddElement(submarine);
            }
        }

        private void AddElement(Vehicle elemento)
        {
            WriteLine("Ingrese una velocidad Maxima");
            elemento.MaximumSpeed = float.Parse(ReadLine());
            WriteLine("Ingrese una velocidad mínima");
            elemento.MinimumSpeed = float.Parse(ReadLine());
            WriteLine("Ingrese una marca");
            elemento.Brand = ReadLine();
            WriteLine("Ingrese un modelo");
            elemento.Model = ReadLine();
            //En vez de ejecutar esta instrucción cada vez que termina el método, se ejecutan los if
            if(elemento.GetType() == typeof(Plane))
            {
                WriteLine("Ingrese una altura máxima");
                ((Plane)elemento).MaximumHeight = float.Parse(ReadLine());
                WriteLine("Ingrese una altura mínima");
                ((Plane)elemento).MinimumHeight = float.Parse(ReadLine());
            }else if(elemento.GetType() == typeof(Submarine))
            {
                WriteLine("Ingrese una profundidad máxima");
                ((Submarine)elemento).MaximumDeep = float.Parse(ReadLine());
            }
            controller.add(elemento);
        }

        private object Search(string id)
        {
            return controller.search(id);
        }

        private void ListVehicle()
        {
            WriteTitle("Tipo de Listado");
            WriteLine("1. General");
            WriteLine("2. Avión");
            WriteLine("3. Submarino");
            WriteLine("Seleccione una opción ==> ");
            string respuesta = ReadLine();
            if(respuesta.Equals("1"))
            {
                controller.find();
                PresionarEnter();
            }
            else if(respuesta.Equals("2"))
            {
                controller.ShowDetail("Plane");
                PresionarEnter();
            }
            else if(respuesta.Equals("3"))
            {
                controller.ShowDetail("Submarine");
                PresionarEnter();
            }
        }

        private void Delete()
        {
            controller.find();
            WriteLine("Ingrese el id a eliminar");
            string id = Console.ReadLine();
            object element = controller.search(id);
            if (element != null)
            {
                WriteLine("Esta seguro de querer eliminar S/N");
                string result = Console.ReadLine();
                if (result.Equals("s"))
                {
                    controller.delete(element);
                    WriteLine("Registro Eliminado");
                    ReadKey();
                }
            }
        }

        private void SearchID()
        {
            controller.find();
            WriteLine("Ingrese el id");
            string res = ReadLine();
            object element = controller.search(res);
            
            if (element != null)
            {
                WriteLine(element);
            }
            else
            {
                WriteLine("No existe");
            }
            ReadKey();
        }
    }
}