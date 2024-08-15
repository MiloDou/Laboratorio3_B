using System.Net.Http.Headers;

namespace Laboratorio3_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Management manager = new Management();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("-------------------------------\n");
                Console.WriteLine("1. Registrar Cliente Regular");
                Console.WriteLine("2. Registrar Cliente VIP");
                Console.WriteLine("3. Registrar Reserva");
                Console.WriteLine("4. Mostrar Clientes");
                Console.WriteLine("5. Mostrar Reservas");
                Console.WriteLine("6. Buscar Cliente");
                Console.WriteLine("7. Buscar Reserva");
                Console.WriteLine("8. Salir");

                try
                {
                    Console.Write("Seleccione una opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            manager.AddClient(false);
                            break;
                        case 2:
                            manager.AddClient(true);
                            break;
                        case 3:
                            manager.AddBooking();
                            break;
                        case 4:
                            manager.MostrarClientes();
                            break;
                        case 5:
                            manager.MostrarReservas();
                            break;
                        case 6:
                            manager.SearchClient();
                            break;
                        case 7:
                            manager.SearchBooking();
                            break;
                        case 8:
                            return;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                catch (FormatException )
                {

                    Console.WriteLine("Formato Invalido");
                }
                Console.ReadKey();
            }
        }
    }
}


