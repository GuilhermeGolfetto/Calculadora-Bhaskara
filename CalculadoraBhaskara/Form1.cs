using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBhaskara
{
    public partial class frmBhaskara : Form
    {
        public frmBhaskara()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //não pode redimensionar
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(txtNumA.Text);
            double b = Convert.ToInt32(txtNumB.Text);
            double c = Convert.ToInt32(txtNumC.Text);

            double delta = (b * b) - 4 * a * c;

            if(a == 0)
            {
                //não possui solução
                pn1.Visible = false;
                MessageBox.Show("Não é equação do 2° grau");
            }
            else { 
            
           if(delta == 0)
            {
                //uma raiz
                double x1 = -b + Math.Sqrt(delta) / (2 * a);
                pn1.Visible = true;
                txtDelta.Text = delta.ToString();
                txtX1.Text = x1.ToString();
                txtX2.Text = x1.ToString();
            }

           if(delta > 0)
            {
                //duas raizes
                double x1 = -b + Math.Sqrt(delta) / (2 * a);
                double x2 = -b - Math.Sqrt(delta) / (2 * a);
                pn1.Visible = true;
                txtDelta.Text = delta.ToString();
                txtX1.Text = x1.ToString();
                txtX2.Text = x2.ToString();
            }
           if(delta < 0)
            {
                    //não tem solução
                    MessageBox.Show("Não possui Solução");
                    pn1.Visible = false;
            }
            }
        }

        private void txtNumA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se não for número
            if (char.IsLetter(e.KeyChar))
            {
                //não aparece na box
                e.Handled = true;
            }
        }

        private void txtNumB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
