namespace ABM_BANCO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCliente = new System.Windows.Forms.Label();
            this.rbtExistente = new System.Windows.Forms.RadioButton();
            this.rbtNuevo = new System.Windows.Forms.RadioButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblTipoCuentas = new System.Windows.Forms.Label();
            this.cboCuentas = new System.Windows.Forms.ComboBox();
            this.lblCBU = new System.Windows.Forms.Label();
            this.txtCBU = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblUltimoMovimiento = new System.Windows.Forms.Label();
            this.txtUltimoMovimiento = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCBU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUltimoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(19, 46);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(67, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CLIENTE:";
            this.lblCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbtExistente
            // 
            this.rbtExistente.AutoSize = true;
            this.rbtExistente.Location = new System.Drawing.Point(106, 42);
            this.rbtExistente.Name = "rbtExistente";
            this.rbtExistente.Size = new System.Drawing.Size(103, 24);
            this.rbtExistente.TabIndex = 1;
            this.rbtExistente.TabStop = true;
            this.rbtExistente.Text = "1-Existente";
            this.rbtExistente.UseVisualStyleBackColor = true;
            // 
            // rbtNuevo
            // 
            this.rbtNuevo.AutoSize = true;
            this.rbtNuevo.Location = new System.Drawing.Point(215, 42);
            this.rbtNuevo.Name = "rbtNuevo";
            this.rbtNuevo.Size = new System.Drawing.Size(87, 24);
            this.rbtNuevo.TabIndex = 2;
            this.rbtNuevo.TabStop = true;
            this.rbtNuevo.Text = "2-Nuevo";
            this.rbtNuevo.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(19, 114);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(270, 27);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(106, 114);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(270, 27);
            this.txtApellido.TabIndex = 6;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(19, 154);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(38, 20);
            this.lblDNI.TabIndex = 7;
            this.lblDNI.Text = "DNI:";
            this.lblDNI.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(106, 154);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(270, 27);
            this.txtDNI.TabIndex = 8;
            // 
            // lblTipoCuentas
            // 
            this.lblTipoCuentas.AutoSize = true;
            this.lblTipoCuentas.Location = new System.Drawing.Point(19, 198);
            this.lblTipoCuentas.Name = "lblTipoCuentas";
            this.lblTipoCuentas.Size = new System.Drawing.Size(113, 20);
            this.lblTipoCuentas.TabIndex = 9;
            this.lblTipoCuentas.Text = "Tipo de Cuenta:";
            // 
            // cboCuentas
            // 
            this.cboCuentas.FormattingEnabled = true;
            this.cboCuentas.Location = new System.Drawing.Point(138, 195);
            this.cboCuentas.Name = "cboCuentas";
            this.cboCuentas.Size = new System.Drawing.Size(238, 28);
            this.cboCuentas.TabIndex = 10;
            this.cboCuentas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCBU
            // 
            this.lblCBU.AutoSize = true;
            this.lblCBU.Location = new System.Drawing.Point(19, 252);
            this.lblCBU.Name = "lblCBU";
            this.lblCBU.Size = new System.Drawing.Size(40, 20);
            this.lblCBU.TabIndex = 11;
            this.lblCBU.Text = "CBU:";
            this.lblCBU.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtCBU
            // 
            this.txtCBU.Location = new System.Drawing.Point(106, 252);
            this.txtCBU.Name = "txtCBU";
            this.txtCBU.Size = new System.Drawing.Size(270, 27);
            this.txtCBU.TabIndex = 12;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(19, 298);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(50, 20);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(106, 298);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(270, 27);
            this.txtSaldo.TabIndex = 14;
            // 
            // lblUltimoMovimiento
            // 
            this.lblUltimoMovimiento.AutoSize = true;
            this.lblUltimoMovimiento.Location = new System.Drawing.Point(19, 341);
            this.lblUltimoMovimiento.Name = "lblUltimoMovimiento";
            this.lblUltimoMovimiento.Size = new System.Drawing.Size(141, 20);
            this.lblUltimoMovimiento.TabIndex = 15;
            this.lblUltimoMovimiento.Text = "Ultimo Movimiento:";
            // 
            // txtUltimoMovimiento
            // 
            this.txtUltimoMovimiento.Location = new System.Drawing.Point(166, 338);
            this.txtUltimoMovimiento.Name = "txtUltimoMovimiento";
            this.txtUltimoMovimiento.Size = new System.Drawing.Size(210, 27);
            this.txtUltimoMovimiento.TabIndex = 16;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNombre,
            this.colApellido,
            this.ColDNI,
            this.colCBU,
            this.colSaldo,
            this.colUltimoMovimiento,
            this.colTipo});
            this.dgvClientes.Location = new System.Drawing.Point(421, 46);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 29;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(555, 319);
            this.dgvClientes.TabIndex = 17;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(38, 409);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(234, 409);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 29);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(440, 409);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(94, 29);
            this.btnGrabar.TabIndex = 20;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(658, 409);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 20;
            this.lstClientes.Location = new System.Drawing.Point(440, 46);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(11, 304);
            this.lstClientes.TabIndex = 22;
            // 
            // colID
            // 
            this.colID.HeaderText = "Id cliente";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 125;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 125;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.MinimumWidth = 6;
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            this.colApellido.Width = 125;
            // 
            // ColDNI
            // 
            this.ColDNI.HeaderText = "DNI";
            this.ColDNI.MinimumWidth = 6;
            this.ColDNI.Name = "ColDNI";
            this.ColDNI.ReadOnly = true;
            this.ColDNI.Width = 125;
            // 
            // colCBU
            // 
            this.colCBU.HeaderText = "CBU";
            this.colCBU.MinimumWidth = 6;
            this.colCBU.Name = "colCBU";
            this.colCBU.ReadOnly = true;
            this.colCBU.Visible = false;
            this.colCBU.Width = 125;
            // 
            // colSaldo
            // 
            this.colSaldo.HeaderText = "Saldo";
            this.colSaldo.MinimumWidth = 6;
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.ReadOnly = true;
            this.colSaldo.Visible = false;
            this.colSaldo.Width = 125;
            // 
            // colUltimoMovimiento
            // 
            this.colUltimoMovimiento.HeaderText = "Ultimo Movimiento";
            this.colUltimoMovimiento.MinimumWidth = 6;
            this.colUltimoMovimiento.Name = "colUltimoMovimiento";
            this.colUltimoMovimiento.ReadOnly = true;
            this.colUltimoMovimiento.Visible = false;
            this.colUltimoMovimiento.Width = 125;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.MinimumWidth = 6;
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Visible = false;
            this.colTipo.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txtUltimoMovimiento);
            this.Controls.Add(this.lblUltimoMovimiento);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtCBU);
            this.Controls.Add(this.lblCBU);
            this.Controls.Add(this.cboCuentas);
            this.Controls.Add(this.lblTipoCuentas);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.rbtNuevo);
            this.Controls.Add(this.rbtExistente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lstClientes);
            this.MaximumSize = new System.Drawing.Size(1006, 497);
            this.MinimumSize = new System.Drawing.Size(1006, 497);
            this.Name = "Form1";
            this.Text = "BANCO PISONI S.A.";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCliente;
        private RadioButton rbtExistente;
        private RadioButton rbtNuevo;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblDNI;
        private TextBox txtDNI;
        private Label lblTipoCuentas;
        private ComboBox cboCuentas;
        private Label lblCBU;
        private TextBox txtCBU;
        private Label lblSaldo;
        private TextBox txtSaldo;
        private Label lblUltimoMovimiento;
        private TextBox txtUltimoMovimiento;
        private DataGridView dgvClientes;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnGrabar;
        private Button btnSalir;
        private ListBox lstClientes;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn ColDNI;
        private DataGridViewTextBoxColumn colCBU;
        private DataGridViewTextBoxColumn colSaldo;
        private DataGridViewTextBoxColumn colUltimoMovimiento;
        private DataGridViewTextBoxColumn colTipo;
    }
}