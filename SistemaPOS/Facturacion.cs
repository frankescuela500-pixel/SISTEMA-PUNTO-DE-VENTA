using LibreriaDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SistemaPOS
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void errorTxtBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorTxtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string vendedor = "Select * from Usuarios Where id_usuario = " + Login.Codigo;

            DataSet ds;

            ds = Biblioteca.Herramientas(vendedor);

            IbVendedor.Text = ds.Tables[0].Rows[0]["username"].ToString().Trim();
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtCodigoCliente.Text.Trim()) == false)
                {
                    string cmd = string.Format("Select Nombre_cliente from Clientes where id_clientes = '{0}'", TxtCodigoCliente.Text.Trim());
                    DataSet ds = Biblioteca.Herramientas(cmd);

                    TxtCliente.Text = ds.Tables[0].Rows[0]["Nombre_cliente"].ToString().Trim();

                    TxtCodigoProducto.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }
        public static int contadorFila = 0;
        public static double total;

        private void BtColocar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int numeroFila = 0;

            if (contadorFila == 0)
            {
                dataGridView1.Rows.Add(TxtCodigoProducto.Text, TxtDescripcion.Text, TxtPrecio.Text, TxtCantidad.Text);
                double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                contadorFila++;
            }
            else
            {
                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    if (Fila.Cells[0].Value.ToString() == TxtCodigoProducto.Text)
                    {
                        existe = true;
                        numeroFila = Fila.Index;
                    }
                }
                if (existe == true)
                {
                    dataGridView1.Rows[numeroFila].Cells[3].Value = (Convert.ToDouble(TxtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[3].Value)).ToString();
                    double importe = Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[3].Value);
                    dataGridView1.Rows[numeroFila].Cells[4].Value = importe;
                }
                else
                {
                    dataGridView1.Rows.Add(TxtCodigoProducto.Text, TxtDescripcion.Text, TxtPrecio.Text, TxtCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                    dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                    contadorFila++;
                }
            }

            total = 0;
            foreach (DataGridViewRow Fila in dataGridView1.Rows)
            {
                if (Fila.Cells[0].Value.ToString() == TxtCodigoProducto.Text)
                {
                    total += Convert.ToDouble(Fila.Cells[4].Value);

                }
                IbTotal.Text = "USD$ " + total.ToString();
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (contadorFila > 0)
            {
                total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                IbTotal.Text = "USD$ " + total.ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                contadorFila--;
            }
        }

        private void BtClientes_Click(object sender, EventArgs e)
        {
            ConsultarCliente ConsulClien = new ConsultarCliente();
            ConsulClien.ShowDialog();

            if (ConsulClien.DialogResult == DialogResult.OK)
            {
                TxtCodigoCliente.Text = ConsulClien.dataGridView1.Rows[ConsulClien.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TxtCliente.Text = ConsulClien.dataGridView1.Rows[ConsulClien.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                TxtCodigoProducto.Focus();
            }
        }

        private void BtProductos_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConsulPro = new ConsultarProductos();
            ConsulPro.ShowDialog();

            if (ConsulPro.DialogResult == DialogResult.OK)
            {
                TxtCodigoProducto.Text = ConsulPro.dataGridView1.Rows[ConsulPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                TxtDescripcion.Text = ConsulPro.dataGridView1.Rows[ConsulPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                TxtPrecio.Text = ConsulPro.dataGridView1.Rows[ConsulPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

                TxtCantidad.Focus();
            }
        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        public override void Nuevo()
        {
            TxtCodigoCliente.Text = "";
            TxtCliente.Text = "";
            TxtCodigoProducto.Text = "";
            TxtDescripcion.Text = "";
            TxtPrecio.Text = "";
            TxtCantidad.Text = "";
            IbTotal.Text = "USD$ 0";
            dataGridView1.Rows.Clear();
            contadorFila = 0;
            total = 0;

            TxtCodigoCliente.Focus();
        }
    }
}
