using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDLL;

namespace SistemaPOS
{
    public partial class Usuario : FormBase
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Usuarios WHERE id_usuario=" + Login.Codigo;
            DataSet Data = Biblioteca.Herramientas(consulta);

            INombre.Text = Data.Tables[0].Rows[0]["username"].ToString();
            IUser.Text = Data.Tables[0].Rows[0]["account"].ToString();
            ICodigo.Text = Data.Tables[0].Rows[0]["id_usuario"].ToString();

            string imagen = Data.Tables[0].Rows[0]["imagen"].ToString().Trim();

            // 🛠️ SOLUCIÓN: Validar si el archivo existe físicamente en el disco
            if (System.IO.File.Exists(imagen))
            {
                pictureBox1.Image = Image.FromFile(imagen);
            }
            else
            {
                // Si no existe, puedes dejarlo vacío o cargar una imagen por defecto de tus recursos
                pictureBox1.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal con_principal = new ContenedorPrincipal();
            this.Hide();
            con_principal.Show();
        }
    }
}
