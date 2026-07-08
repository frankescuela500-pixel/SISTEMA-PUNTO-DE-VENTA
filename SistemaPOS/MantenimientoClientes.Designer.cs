namespace SistemaPOS
{
    partial class MantenimientoClientes
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textApellido_Cliente = new LibreriaDLL.ErrorTxtBox();
            this.textNombre_Cliente = new LibreriaDLL.ErrorTxtBox();
            this.textId_Cliente = new LibreriaDLL.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 255);
            this.button1.Size = new System.Drawing.Size(62, 42);
            this.button1.Text = "Consultar Clientes";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 255);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 255);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(392, 255);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(392, 310);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 37);
            this.label4.TabIndex = 17;
            this.label4.Text = "CLIENTES";
            // 
            // textApellido_Cliente
            // 
            this.textApellido_Cliente.Location = new System.Drawing.Point(256, 170);
            this.textApellido_Cliente.Name = "textApellido_Cliente";
            this.textApellido_Cliente.Size = new System.Drawing.Size(174, 20);
            this.textApellido_Cliente.TabIndex = 20;
            this.textApellido_Cliente.Validar = true;
            this.textApellido_Cliente.ValidarNumeros = false;
            // 
            // textNombre_Cliente
            // 
            this.textNombre_Cliente.Location = new System.Drawing.Point(256, 127);
            this.textNombre_Cliente.Name = "textNombre_Cliente";
            this.textNombre_Cliente.Size = new System.Drawing.Size(174, 20);
            this.textNombre_Cliente.TabIndex = 19;
            this.textNombre_Cliente.Validar = true;
            this.textNombre_Cliente.ValidarNumeros = false;
            // 
            // textId_Cliente
            // 
            this.textId_Cliente.Location = new System.Drawing.Point(256, 81);
            this.textId_Cliente.Name = "textId_Cliente";
            this.textId_Cliente.Size = new System.Drawing.Size(174, 20);
            this.textId_Cliente.TabIndex = 18;
            this.textId_Cliente.Validar = true;
            this.textId_Cliente.ValidarNumeros = false;
            this.textId_Cliente.TextChanged += new System.EventHandler(this.textId_Cliente_TextChanged);
            // 
            // MantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textApellido_Cliente);
            this.Controls.Add(this.textNombre_Cliente);
            this.Controls.Add(this.textId_Cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoClientes";
            this.Text = "MantenimientoClientes";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textId_Cliente, 0);
            this.Controls.SetChildIndex(this.textNombre_Cliente, 0);
            this.Controls.SetChildIndex(this.textApellido_Cliente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private LibreriaDLL.ErrorTxtBox textId_Cliente;
        private LibreriaDLL.ErrorTxtBox textNombre_Cliente;
        private LibreriaDLL.ErrorTxtBox textApellido_Cliente;
    }
}