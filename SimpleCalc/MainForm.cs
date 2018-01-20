using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
       
       
        private void oneBTN_Click(object sender, EventArgs e)
        {  
            operationTXT.Text = operationTXT.Text + "1";
        }

        private void twoBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "2";
        }

        private void threeBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "3";
        }

        private void fourBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "4";
        }

        private void fiveBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "5";
        }

        private void sixBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "6";
        }

        private void sevenBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "7";
        }

        private void eightBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "8";
        }

        private void nineBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "9";
        }

        private void zeroBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "0";
        }

        private void dotBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + ".";
        }

        private void sumBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "+";
        }

        private void subBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "-";
        }

        private void mulBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "*";
        }

        private void divBTN_Click(object sender, EventArgs e)
        {
            operationTXT.Text = operationTXT.Text + "/";
        }

        private void equalBTN_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
