using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Home : Form
    {
        public 
            Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtxtResults.Text = LbListaCosas.Text + "\r\n";  

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                bool error = false;

                foreach (char caracter in txbNombre.Text)
                {
                    if (char.IsDigit(caracter))
                    {
                        error = true;
                        break;
                    }
                }

                if (error)
                {
                    errorProvider1.SetError(txbNombre, "No se admiten números");
                }
                else
                    errorProvider1.Clear();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblP1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report reporte= new Report(rtxtResults.Text);

            reporte.Show();

           
        }

        private void LbListaCosas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LbListaCosas.SelectedIndex!=-1)
                LbListaCosas.Text = (string)LbListaCosas.Items[LbListaCosas.SelectedIndex];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LbListaCosas.Items.Add(txbNombre.Text);
            {
                bool error = false;
                    
                foreach(char caracter in txbNombre.Text)
                {
                    if (char.IsDigit(caracter))
                    {
                        error = true;
                        break;
                    }
                }

                if (error)
                {
                    errorProvider1.SetError(txbNombre, "No se admiten números");
                }
                else
                    errorProvider1.Clear();
            }
            {

                if (rbG.Checked)
                {
                    this.LbListaCosas.Text = txbNombre.Text + "grande";
                }
                {
                    if (rbP.Checked)
                    {
                        this.LbListaCosas.Text = txbNombre.Text + "pequeño";
                    }
                }
                
            }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indice = LbListaCosas.SelectedIndex;

            if (indice != -1)
            {
                LbListaCosas.Items.RemoveAt(indice);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            
        }

        private void rtxtResults_TextChanged(object sender, EventArgs e) => rtxtResults.Text = LbListaCosas.Text;

        private void rbG_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
