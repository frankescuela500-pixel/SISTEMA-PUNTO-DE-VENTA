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
    public partial class ConsultarCliente : Consultas
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet DS;
                    string buscar = "Select * from Clientes WHERE Nombre_producto LIKE ('%" + textBox1.Text.Trim() + "%')";

                    DS = Biblioteca.Herramientas(buscar);

                    dataGridView1.DataSource = DS.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("No se puede conectar, Error: ", error.Message);
                }
            }
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarInfoDG("Clientes").Tables[0];
        }
    }
}
