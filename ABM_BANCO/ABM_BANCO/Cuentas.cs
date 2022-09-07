using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_BANCO
{
    internal class Cuentas
    {
        
            private int cbu;
            private decimal saldo;
            private decimal ultimoMovimiento;


            public int pCbu { get; set; }
            public decimal pSaldo { get; set; }
            public decimal pultimoMovimiento { get; set; }


            public Cuentas()
            {
                this.cbu = 0;
                this.saldo = 0;
                this.ultimoMovimiento = 0;


            }
            public Cuentas(int cbu, decimal saldo, decimal ultimoMovimiento)
            {
                this.cbu = cbu;
                this.saldo = saldo;
                this.ultimoMovimiento = ultimoMovimiento;

            }
            public override string ToString()
            {
                return cbu + " - " + saldo + " - " + ultimoMovimiento;
            }
        
    }
}

