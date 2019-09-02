using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FlameOffice_Carlos_1705971.Classes
{
    class Usuario : Login, ILOperacaos
    {
        public string Nome { get; set; }


        public string GerarHash()
        {
            string hash = MD5.Create().Hash.ToString();
            return hash;
        }

        public List<object> GerarLista()
        {
            List<object> listaUsuario = new List<object>();
            return listaUsuario;
        }
    }
}
