using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo1
{
    public partial class Form1 : Form
    {
        string Operat="";
        double LastNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void BtnNumClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            LalView.Text = "";
        }

        private void BtnNumAdd1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = (Convert.ToUInt32(textBox1.Text) + 3).ToString();
            else
                textBox1.Text = "3";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LalView.Text = "哈哈哈哈哈";
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Operat = "+";
            if (textBox1.Text != "")
                LastNum = Convert.ToDouble(textBox1.Text);
            else
                LastNum = 0;
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (Operat == "+"){
                textBox1.Text = (Convert.ToDouble(textBox1.Text) + LastNum).ToString();
                Operat="";
            }
        }
    }
}
