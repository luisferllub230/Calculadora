using Calculadora.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        CalculatorControler cal = new CalculatorControler();
        String num = "0";

        
        public Form1()
        {
            InitializeComponent(); 
        }

        //close
        private void BTNClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //minimized
        private void BTNminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //num1
        private void button1_Click(object sender, EventArgs e)
        {
            String n1 = goback("1");
            LBLnumber.Text += n1;
        }
        //num2
        private void button2_Click(object sender, EventArgs e)
        {
            String n2 = goback("2");
            LBLnumber.Text += n2;
        }
        //3
        private void button3_Click(object sender, EventArgs e)
        {
            String n3 = goback("3");
            LBLnumber.Text += n3;
        }
        //4
        private void button4_Click(object sender, EventArgs e)
        {
            String n4 = goback("4");
            LBLnumber.Text += n4;
        }
        //5
        private void button5_Click(object sender, EventArgs e)
        {
            String n5 = goback("5");
            LBLnumber.Text += n5;
        }
        //6
        private void button6_Click(object sender, EventArgs e)
        {
            String n6 = goback("6");
            LBLnumber.Text += n6;
        }
        //7
        private void button7_Click(object sender, EventArgs e)
        {
            String n7 = goback("7");
            LBLnumber.Text += n7;
        }
        //8
        private void button8_Click(object sender, EventArgs e)
        {
            String n8 = goback("8");
            LBLnumber.Text += n8;

        }
        //9
        private void button9_Click(object sender, EventArgs e)
        {
            String n9 = goback("9");
            LBLnumber.Text += n9;
        }
        //num0
        private void button11_Click(object sender, EventArgs e)
        {
            String n11 = goback("0");
            LBLnumber.Text += n11;
        }


        //clean
        private void BTNclean_Click(object sender, EventArgs e)
        {
            LBLnumber.Text = "0";
        }

        //do not repeat numbers
        String goback(String n)
        {
            if (LBLnumber.Text == "0")
            {
                LBLnumber.Text = "";
            }
            return n;
        }

    }
}
