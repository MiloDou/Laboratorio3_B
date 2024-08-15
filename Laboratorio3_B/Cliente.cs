
namespace Laboratorio3_B
{
    public abstract class Cliente
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        public Cliente(int id, string name, string email, int phone)
        {
            ID = id;
            Name = name;
            Email = email;
            Phone = phone;

        }
        public abstract bool IsVIP { get; }

        public void MostrarInformacion()
        {
            string tipoCliente = IsVIP ? "VIP" : "Regular";
            Console.WriteLine($"ID: {ID}, Nombre: {Name}, Email: {Email}, Teléfono: {Phone}, Tipo: {tipoCliente}");
        }
    }
}