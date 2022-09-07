using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ABM_BANCO
{
    public partial class Form1 : Form
    {
        Conexion oBD = new Conexion();
        
        public Form1()
        {
            InitializeComponent();
            cargarCombo();
            Clientes cliente = new Clientes();
            Habilitar(false);
            SiempreInhabilitado(false);
            CargarLista();
            Limpiar();
           
        }

        private void cargarCombo()
        {
            DataTable tabla = oBD.consultarBD("SP_TipoCtas");
          

            cboCuentas.DataSource = tabla;
            cboCuentas.ValueMember = tabla.Columns[0].ColumnName;
            cboCuentas.DisplayMember = tabla.Columns[1].ColumnName;
            cboCuentas.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void CargarLista()
        {
            DataTable tabla = oBD.consultarBD("listadoClientes");
           dgvClientes.Rows.Clear();
           
            foreach (DataRow fila in tabla.Rows)
            {
                Clientes C = new Clientes();
                C.pNCliente= Convert.ToInt32(fila["id_cliente"].ToString());
                C.pNombre = (fila["nombre"].ToString());
                C.pApellido = (fila["apellido"].ToString());
                C.pDNI = Convert.ToInt32(fila["dni"].ToString());

                

                Cuentas Cu = new Cuentas();
                Cu.pCbu= Convert.ToInt32(fila["cbu"].ToString());
                Cu.pSaldo= Convert.ToDecimal(fila["saldo"].ToString());
                Cu.pultimoMovimiento=Convert.ToDecimal(fila["ultimoMovimiento"].ToString());

                TipoCuenta TP = new TipoCuenta();
                TP.pNombreTipo = (fila["nombre"].ToString());
                

                dgvClientes.Rows.Add(new object[] { C.pNCliente, C.pNombre, C.pApellido, C.pDNI, Cu.pCbu, Cu.pSaldo, Cu.pultimoMovimiento, TP.pNombreTipo });
            }
            
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Habilitar(true);
            SiempreInhabilitado(false);
            Limpiar();



        }

        private bool validar()
        {
            bool resultado = true;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                resultado = false;
                MessageBox.Show("No se ingreso el nombre del cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                resultado = false;
                MessageBox.Show("No se ingreso el apellido del cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                resultado = false;
                MessageBox.Show("No se ingreso el DNI del cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!rbtNuevo.Checked && !rbtExistente.Checked)
            {
                resultado = false;
                MessageBox.Show("No se selecciono si es cliente nuevo o existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            return resultado;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string nombreSP;
            Clientes C = new Clientes();
            C.pNombre = txtNombre.Text;
            C.pApellido = txtApellido.Text;
            C.pDNI = Convert.ToInt32(txtDNI.Text);
            
            nombreSP = "SP_ClienteNuevo";
            
            List<Parametros> lista = new List<Parametros>();
            lista.Add(new Parametros("@nombre", C.pNombre));
            lista.Add(new Parametros("@apellido", C.pApellido));
            lista.Add(new Parametros("@DNI", C.pDNI));
            
            oBD.ActualizarBD(nombreSP, lista);
            Habilitar(false);
        }

        private void Habilitar (bool x)
        {
            txtNombre.Enabled = x;
            txtApellido.Enabled = x;
            txtDNI.Enabled= x;
            txtSaldo.Enabled= x;    
            txtUltimoMovimiento.Enabled= x;
            txtCBU.Enabled= x;
            btnGrabar.Enabled = x;
            btnNuevo.Enabled = !x;
            rbtExistente.Enabled = x;
            rbtNuevo.Enabled = x;  
            btnEditar.Enabled = x;
            cboCuentas.Enabled = x;
            
        }

        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCBU.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtSaldo.Text = String.Empty;
            txtUltimoMovimiento.Text = String.Empty;
            cboCuentas.SelectedIndex = -1;
       
        }
        private void SiempreInhabilitado(bool x)
        {
            
            txtSaldo.Enabled = x;
            txtUltimoMovimiento.Enabled = x;
            txtCBU.Enabled = x;
          
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro?", "SALIR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { this.Dispose(); }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow.Index > 0)
            {
                //txtNcliente.Text = dgvClientes.CurrentRow.Cells["id_cliente"].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells["colNombre"].Value.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells["colApellido"].Value.ToString();
                txtDNI.Text = dgvClientes.CurrentRow.Cells["colDNI"].Value.ToString();
                txtCBU.Text = dgvClientes.CurrentRow.Cells["colCBU"].Value.ToString();
                txtSaldo.Text = dgvClientes.CurrentRow.Cells["colSaldo"].Value.ToString();
                txtUltimoMovimiento.Text = dgvClientes.CurrentRow.Cells["colUltimoMovimiento"].Value.ToString();
                cboCuentas.Text=dgvClientes.CurrentRow.Cells["colTipo"].Value.ToString();
                

            }
        }
    }
}