using Business.Enumarator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Business
    {
        private object[] estados = new object[27];

        public object[] GetEstado()
        {
            EnumEstado enumEstado = new EnumEstado();
            
            foreach(int estado in Enum.GetValues(typeof(EnumEstado.Estado)))
            {
                estados[estado] = (EnumEstado.Estado)estado;
                Console.WriteLine(estados[estado].ToString());
            }
            return estados;
        }
    }
}
