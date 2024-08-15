using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio3_B
{
    public class Management
    {
        private List<Cliente> clientes;
        private List<Reserva> reservas;

        public Management()
        {
            clientes = new List<Cliente>();
            reservas = new List<Reserva>();
        }

        public void AddClient(bool isVIP)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(isVIP ? "REGISTRO DE CLIENTE VIP" : "REGISTRO DE CLIENTE REGULAR");
            Console.WriteLine("---------------------------------------");
            try
            {
                Console.Write("Escriba ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escriba nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Escriba correo: ");
                string email = Console.ReadLine();
                Console.Write("Escriba teléfono: ");
                int telefono = Convert.ToInt32(Console.ReadLine());

                Cliente nuevoCliente = new Cliente(id, nombre, email, telefono);
                clientes.Add(nuevoCliente);
                Console.WriteLine($"\nCliente {nombre} registrado correctamente.");

            }
            catch (FormatException)
            {
                Console.WriteLine("Formato Inválido");
            }
            Console.ReadKey();
        }

        public void AddDishToReservation(List<Platillo> platillos)
        {
            bool agregarMas = true;
            while (agregarMas)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("AGREGAR PLATILLO");
                    Console.WriteLine("--------------------------");
                    Console.Write("Nombre del platillo: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Precio del platillo: Q");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    Platillo platillo = new Platillo(nombre, precio);
                    platillos.Add(platillo);

                }
                catch (FormatException)
                {

                    Console.WriteLine("Formato Inválido");
                }
                
                Console.Write("¿Agregar otro platillo? (y/n): ");
                string continuar = Console.ReadLine();
                agregarMas = continuar.ToLower() == "y";
            }
        }

        public void AddBooking()
        {

            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("AGREGAR RESERVA");
            Console.WriteLine("--------------------------");
            Console.Write("Ingrese el ID del cliente: ");
            int clienteId = Convert.ToInt32(Console.ReadLine());

            Cliente clienteAsociado = clientes.FirstOrDefault(c => c.ID == clienteId);
            if (clienteAsociado == null)
            {
                Console.WriteLine("Cliente no encontrado.");
                return;
            }

            Console.Write("Número de reserva: ");
            int uniqueNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fecha (dd/MM/yyyy HH:mm): ");
            DateTime fecha = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);

            List<Platillo> platillos = new List<Platillo>();
            AddDishToReservation(platillos);

            Reserva nuevaReserva = new Reserva(uniqueNumber, fecha, clienteAsociado, platillos);
            reservas.Add(nuevaReserva);

            Console.WriteLine("Reserva agregada correctamente.");
            Console.ReadKey();
        }

        public void MostrarClientes()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("LISTA DE CLIENTES:");
            Console.WriteLine("--------------------------");
            foreach (var cliente in clientes)
            {
                cliente.MostrarInformacion();
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void MostrarReservas()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("LISTA DE RESERVAS:");
            Console.WriteLine("--------------------------");
            foreach (var reserva in reservas)
            {
                reserva.MostrarInformacionReserva();
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void SearchClient()
        {
            Console.Clear();
            try
            {
                Console.Write("Ingrese el nombre del cliente: ");
                string nombre = Console.ReadLine().ToLower();
                var cliente = clientes.FirstOrDefault(c => c.Name.ToLower() == nombre);

                if (cliente != null)
                {
                    cliente.MostrarInformacion();
                }
                else
                {
                    Console.WriteLine("Cliente no encontrado.");
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Formato inválido");
            }
            Console.ReadKey();
        }

        public void SearchBooking()
        {
            Console.Clear();
            try
            {
                Console.Write("Ingrese el número de reserva: ");
                int numeroReserva = Convert.ToInt32(Console.ReadLine());
                var reserva = reservas.FirstOrDefault(r => r.UniqueNumber == numeroReserva);

                if (reserva != null)
                {
                    reserva.MostrarInformacionReserva();
                }
                else
                {
                    Console.WriteLine("Reserva no encontrada.");
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Formato Inválido");
            }
            Console.ReadKey();
        }
    }
}

    