using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_B
{
    public class Platillo
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Platillo(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Platillo: {Nombre}, Precio: Q{Precio}");
        }
    }
}
