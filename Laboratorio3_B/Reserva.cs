using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_B
{
    public class Reserva
    {
        public int UniqueNumber { get; set; }
        public DateTime Fecha { get; set; }
        public List<Platillo> Platillos { get; set; }
        public Cliente ClienteAsociado { get; set; }
        public double Total { get; set; }

        public Reserva(int uniqueNumber, DateTime fecha, Cliente clienteAsociado, List<Platillo> platillos)
        {
            UniqueNumber = uniqueNumber;
            Fecha = fecha;
            ClienteAsociado = clienteAsociado;
            Platillos = platillos;
            Total = CalcularTotal();
        }

        public double CalcularTotal()
        {
            double total = Platillos.Sum(p => p.Precio);
            if (ClienteAsociado.IsVIP)
            {
                total *= 0.95; 
            }
            return total;
        }
        public void MostrarInformacionReserva()
        {
            Console.WriteLine($"Reserva: {UniqueNumber}, Fecha: {Fecha}, Cliente: {ClienteAsociado.Name}, Total: Q{Total}");
            Console.WriteLine("Platillos:");
            foreach (var platillo in Platillos)
            {
                platillo.MostrarInformacion();
            }
        }

    }
}
