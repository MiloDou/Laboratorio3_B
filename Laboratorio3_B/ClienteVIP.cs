using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_B
{
    public class ClienteVip : Cliente
    {
        public ClienteVip(int id, string name, string email, int phone):base(id, name, email, phone) { }

        public override bool IsVIP => true;
    }
}
