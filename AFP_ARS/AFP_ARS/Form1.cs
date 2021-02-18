using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFP_ARS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtSalario.Text == "")
            {
                MessageBox.Show("Debe llenar la casilla de salario para que cálculo sea realizado");
                txtSalario.Focus();
                return;
            }

            try
            {
                double salario = double.Parse(txtSalario.Text) < 7000 ? 7000 : double.Parse(txtSalario.Text);
                salario = salario > 200000 ? 200000 : salario;


                double afpSalario = salario * 0.0287;
                double arsSalario = salario * 0.0304;

                double total = salario - afpSalario - arsSalario;

                txtAFP.Text = afpSalario.ToString();
                txtARS.Text = arsSalario.ToString();
                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el cálculo: " + ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
