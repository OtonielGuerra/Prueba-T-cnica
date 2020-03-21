using System;
using static Jonathan_Guerra.Util.Printer;
using Jonathan_Guerra.Menu;

namespace Jonathan_Guerra
{
    class Program
    {
        static void Main(string[] args)
        {
            Beep();
            WriteTitle("Vehiculos");
            new MainMenu().ViewMenu();
        }
    }
}
