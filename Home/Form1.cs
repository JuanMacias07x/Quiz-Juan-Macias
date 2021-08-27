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
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indice = LbListaCosas.SelectedIndex;

            if (indice != -1) ;
            {
                LbListaCosas.Items.RemoveAt(indice);
            }
        }
    }
}
