using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperDemo
{
    public partial class Form1 : Form
    {
        SuppliersRepository suppliersR = new SuppliersRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            var categoria = suppliersR.ObtenerTodos();
            dgvCategoria.DataSource = categoria;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnObtenerId_Click(object sender, EventArgs e)
        {
            var categoria = suppliersR.ObtenerPorID(tboxObtenerID.Text);
            dgvCategoria.DataSource = new List<Suppliers> { categoria };
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var eliminadas = suppliersR.EliminarCategoria(tboxObtenerID.Text);
            MessageBox.Show($"Se ha eliminado {eliminadas} filas de manera correcta");
        }
    }
}
