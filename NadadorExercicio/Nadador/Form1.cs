using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nadador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double distancia;
            distancia = Convert.ToDouble(txtdistancia.Text);
            if (distancia < 800)
            {
                txtpremiacao.Text = "Seu  prêmio é de R$5.000";
            }
            else if (distancia > 800 && distancia < 1500)
            {
                txtpremiacao.Text = "Seu  prêmio é de R$10.000";
            }
            else
            {
                txtpremiacao.Text = "Seu prêmio é de R$15.000";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtdistancia.Clear();
            txtpremiacao.Clear();
        }
    }
}
        
    

