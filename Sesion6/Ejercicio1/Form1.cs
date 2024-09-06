using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre=tbNombre.Text;
            cmbNombres.Items.Add(nombre);
            tbNombre.Text = "";
            tbNombre.Focus();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            agregar();
        }

        public void agregar()
        {
            string nombre = tbNombre.Text.Trim();//trim borra los espacios en blanco al inicio y al final de un texto;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("No puede quedar vacio el nombre");
                tbNombre = null;
                return;
            }
            cmbNombres.Items.Add(nombre);
            tbNombre.Text = "";
            tbNombre.Focus();
        }
        private void cmdNombres2_SelectedIndexChange(object sender, EventArgs e)
        {
            int cant = cmbNombres.Items.Count;
            for(int i =0; i<cant; i++)
            {
                string nombre=cmbNombres.Items[i].ToString();
                cmbNombres.Items.Add(nombre);
            }
        }
    }
}
