using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_BANCO
{
    public class Clientes
    {
        private int nCliente;
        private string nombre;
        private string apellido;
        private int DNI;

        public int pNCliente { get; set; } 
        public string pNombre { get; set; } 
        public string pApellido { get; set; }
        public int pDNI { get; set; }

        public Clientes()
        {
            this.nCliente = 0;
            this.nombre = "";
            this.apellido = "";
            this.DNI = 0;
           
        }
        public Clientes(int nCliente, string nombre, string apellido, int DNI)
        {
            this.nCliente = nCliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = DNI;
           
        }
        public override string ToString()
        {
            return nCliente + " - " + nombre;
        }
    }
}
