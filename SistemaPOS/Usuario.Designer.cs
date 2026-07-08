namespace SistemaPOS
{
    partial class Usuario
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ICodigo = new System.Windows.Forms.Label();
            this.IUser = new System.Windows.Forms.Label();
            this.INombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(415, 325);
            this.btnSalir.Size = new System.Drawing.Size(183, 21);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Usuario:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(415, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Cerrar sesión";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Cambiar contraseña";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ICodigo
            // 
            this.ICodigo.BackColor = System.Drawing.Color.White;
            this.ICodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ICodigo.Location = new System.Drawing.Point(265, 115);
            this.ICodigo.Name = "ICodigo";
            this.ICodigo.Size = new System.Drawing.Size(100, 20);
            this.ICodigo.TabIndex = 16;
            this.ICodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IUser
            // 
            this.IUser.BackColor = System.Drawing.Color.White;
            this.IUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IUser.Location = new System.Drawing.Point(265, 78);
            this.IUser.Name = "IUser";
            this.IUser.Size = new System.Drawing.Size(100, 20);
            this.IUser.TabIndex = 15;
            this.IUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INombre
            // 
            this.INombre.BackColor = System.Drawing.Color.White;
            this.INombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.INombre.Location = new System.Drawing.Point(265, 40);
            this.INombre.Name = "INombre";
            this.INombre.Size = new System.Drawing.Size(100, 20);
            this.INombre.TabIndex = 14;
            this.INombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(391, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 374);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ICodigo);
            this.Controls.Add(this.IUser);
            this.Controls.Add(this.INombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(666, 413);
            this.MinimumSize = new System.Drawing.Size(666, 413);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Usuario_FormClosed);
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.INombre, 0);
            this.Controls.SetChildIndex(this.IUser, 0);
            this.Controls.SetChildIndex(this.ICodigo, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ICodigo;
        private System.Windows.Forms.Label IUser;
        private System.Windows.Forms.Label INombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}