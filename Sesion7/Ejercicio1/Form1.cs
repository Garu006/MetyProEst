using Ejercicio1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        GeneralAge ages=new GeneralAge();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            try
            {
                int age = Convert.ToInt32(tbAge.Text);
                ages.AddElement(age, index);
                index++;
                ShowAges();
                tbAge.Clear();
                tbAge.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowAges()
        {
            try
            {
                lbAges.Items.Clear();
                for (int i = 0;i< index; i++)
                {
                    lbAges.Items.Add(ages.GetElements()[(int)i]);  
                }
                int sum = ages.GetElements().Sum();
                double average = ages.GetElements().Average();
                lbsum.Text = "Suma: " + sum;
                lbaverage.Text = "Promedio: " + average;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                Add();
            }
        }
        private void suma()
        {

        }
    }
}
