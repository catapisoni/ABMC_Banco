using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ABM_BANCO
{
  
        internal class TipoCuenta
        {
            private string nombreTipo;
            private int idTipoCuenta;

            public TipoCuenta()
            {
                nombreTipo = string.Empty;
                idTipoCuenta = 0;
            }

            public int pIdTipoCuenta
            { get { return idTipoCuenta; } set { idTipoCuenta = value; } }
            public string pNombreTipo
            { get { return nombreTipo; } set { nombreTipo = value; } }

        public override string ToString()
        {
            return "Tipo de cuenta: " + pNombreTipo;
        }
    }
    }

