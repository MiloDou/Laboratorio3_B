using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_B
{
    public class ClienteRegular : Cliente
    {
        public ClienteRegular(int id, string name, string email, int phone):base(id, name, email, phone) { }

        public override bool IsVIP => false;
    }

}
