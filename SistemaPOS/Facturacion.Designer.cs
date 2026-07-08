namespace SistemaPOS
{
    partial class Facturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtClientes = new System.Windows.Forms.Button();
            this.BtProductos = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtColocar = new System.Windows.Forms.Button();
            this.BtFacturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPrecio = new LibreriaDLL.ErrorTxtBox();
            this.TxtCodigoCliente = new LibreriaDLL.ErrorTxtBox();
            this.TxtCliente = new LibreriaDLL.ErrorTxtBox();
            this.TxtCantidad = new LibreriaDLL.ErrorTxtBox();
            this.TxtCodigoProducto = new LibreriaDLL.ErrorTxtBox();
            this.TxtDescripcion = new LibreriaDLL.ErrorTxtBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IbTotal = new System.Windows.Forms.Label();
            this.BtNuevo = new System.Windows.Forms.Button();
            this.IbVendedor = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(841, 483);
            this.btnSalir.Size = new System.Drawing.Size(92, 42);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(371, 52);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtBuscar.TabIndex = 1;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtClientes
            // 
            this.BtClientes.Location = new System.Drawing.Point(453, 143);
            this.BtClientes.Name = "BtClientes";
            this.BtClientes.Size = new System.Drawing.Size(75, 23);
            this.BtClientes.TabIndex = 2;
            this.BtClientes.Text = "Clientes";
            this.BtClientes.UseVisualStyleBackColor = true;
            this.BtClientes.Click += new System.EventHandler(this.BtClientes_Click);
            // 
            // BtProductos
            // 
            this.BtProductos.Location = new System.Drawing.Point(534, 143);
            this.BtProductos.Name = "BtProductos";
            this.BtProductos.Size = new System.Drawing.Size(75, 23);
            this.BtProductos.TabIndex = 3;
            this.BtProductos.Text = "Productos";
            this.BtProductos.UseVisualStyleBackColor = true;
            this.BtProductos.Click += new System.EventHandler(this.BtProductos_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(615, 143);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtEliminar.TabIndex = 4;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtColocar
            // 
            this.BtColocar.Location = new System.Drawing.Point(696, 143);
            this.BtColocar.Name = "BtColocar";
            this.BtColocar.Size = new System.Drawing.Size(75, 23);
            this.BtColocar.TabIndex = 5;
            this.BtColocar.Text = "Colocar";
            this.BtColocar.UseVisualStyleBackColor = true;
            this.BtColocar.Click += new System.EventHandler(this.BtColocar_Click);
            // 
            // BtFacturar
            // 
            this.BtFacturar.Location = new System.Drawing.Point(777, 143);
            this.BtFacturar.Name = "BtFacturar";
            this.BtFacturar.Size = new System.Drawing.Size(75, 23);
            this.BtFacturar.TabIndex = 6;
            this.BtFacturar.Text = "Facturar";
            this.BtFacturar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(741, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Importe";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Código";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(218, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripción";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(389, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(567, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cantidad";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(411, 185);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(127, 20);
            this.TxtPrecio.TabIndex = 15;
            this.TxtPrecio.Validar = true;
            this.TxtPrecio.ValidarNumeros = false;
            // 
            // TxtCodigoCliente
            // 
            this.TxtCodigoCliente.Location = new System.Drawing.Point(102, 54);
            this.TxtCodigoCliente.Name = "TxtCodigoCliente";
            this.TxtCodigoCliente.Size = new System.Drawing.Size(253, 20);
            this.TxtCodigoCliente.TabIndex = 17;
            this.TxtCodigoCliente.Validar = true;
            this.TxtCodigoCliente.ValidarNumeros = false;
            this.TxtCodigoCliente.TextChanged += new System.EventHandler(this.errorTxtBox3_TextChanged);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtCliente.Location = new System.Drawing.Point(102, 82);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(253, 20);
            this.TxtCliente.TabIndex = 18;
            this.TxtCliente.Validar = true;
            this.TxtCliente.ValidarNumeros = false;
            this.TxtCliente.TextChanged += new System.EventHandler(this.errorTxtBox4_TextChanged);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(590, 185);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(133, 20);
            this.TxtCantidad.TabIndex = 19;
            this.TxtCantidad.Validar = true;
            this.TxtCantidad.ValidarNumeros = false;
            this.TxtCantidad.TextChanged += new System.EventHandler(this.errorTxtBox5_TextChanged);
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.Location = new System.Drawing.Point(75, 185);
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(115, 20);
            this.TxtCodigoProducto.TabIndex = 20;
            this.TxtCodigoProducto.Validar = true;
            this.TxtCodigoProducto.ValidarNumeros = false;
            this.TxtCodigoProducto.TextChanged += new System.EventHandler(this.errorTxtBox6_TextChanged);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(247, 163);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(124, 57);
            this.TxtDescripcion.TabIndex = 21;
            this.TxtDescripcion.Validar = true;
            this.TxtDescripcion.ValidarNumeros = false;
            this.TxtDescripcion.TextChanged += new System.EventHandler(this.errorTxtBox7_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Importe});
            this.dataGridView1.Location = new System.Drawing.Point(44, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(889, 223);
            this.dataGridView1.TabIndex = 22;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 177;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 177;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 177;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 177;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.Width = 177;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(452, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 125);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(627, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Total:";
            // 
            // IbTotal
            // 
            this.IbTotal.BackColor = System.Drawing.Color.White;
            this.IbTotal.Location = new System.Drawing.Point(676, 495);
            this.IbTotal.Name = "IbTotal";
            this.IbTotal.Size = new System.Drawing.Size(95, 29);
            this.IbTotal.TabIndex = 25;
            // 
            // BtNuevo
            // 
            this.BtNuevo.Location = new System.Drawing.Point(858, 143);
            this.BtNuevo.Name = "BtNuevo";
            this.BtNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtNuevo.TabIndex = 26;
            this.BtNuevo.Text = "Nuevo";
            this.BtNuevo.UseVisualStyleBackColor = true;
            this.BtNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // IbVendedor
            // 
            this.IbVendedor.BackColor = System.Drawing.Color.White;
            this.IbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbVendedor.ForeColor = System.Drawing.Color.White;
            this.IbVendedor.Location = new System.Drawing.Point(102, 12);
            this.IbVendedor.Name = "IbVendedor";
            this.IbVendedor.Size = new System.Drawing.Size(253, 31);
            this.IbVendedor.TabIndex = 27;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 536);
            this.Controls.Add(this.IbVendedor);
            this.Controls.Add(this.BtNuevo);
            this.Controls.Add(this.IbTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCodigoProducto);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.TxtCodigoCliente);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtFacturar);
            this.Controls.Add(this.BtColocar);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtProductos);
            this.Controls.Add(this.BtClientes);
            this.Controls.Add(this.BtBuscar);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.BtBuscar, 0);
            this.Controls.SetChildIndex(this.BtClientes, 0);
            this.Controls.SetChildIndex(this.BtProductos, 0);
            this.Controls.SetChildIndex(this.BtEliminar, 0);
            this.Controls.SetChildIndex(this.BtColocar, 0);
            this.Controls.SetChildIndex(this.BtFacturar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtPrecio, 0);
            this.Controls.SetChildIndex(this.TxtCodigoCliente, 0);
            this.Controls.SetChildIndex(this.TxtCliente, 0);
            this.Controls.SetChildIndex(this.TxtCantidad, 0);
            this.Controls.SetChildIndex(this.TxtCodigoProducto, 0);
            this.Controls.SetChildIndex(this.TxtDescripcion, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.IbTotal, 0);
            this.Controls.SetChildIndex(this.BtNuevo, 0);
            this.Controls.SetChildIndex(this.IbVendedor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtBuscar;
        private System.Windows.Forms.Button BtClientes;
        private System.Windows.Forms.Button BtProductos;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtColocar;
        private System.Windows.Forms.Button BtFacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private LibreriaDLL.ErrorTxtBox TxtPrecio;
        private LibreriaDLL.ErrorTxtBox TxtCodigoCliente;
        private LibreriaDLL.ErrorTxtBox TxtCliente;
        private LibreriaDLL.ErrorTxtBox TxtCantidad;
        private LibreriaDLL.ErrorTxtBox TxtCodigoProducto;
        private LibreriaDLL.ErrorTxtBox TxtDescripcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label IbTotal;
        private System.Windows.Forms.Button BtNuevo;
        private System.Windows.Forms.Label IbVendedor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}