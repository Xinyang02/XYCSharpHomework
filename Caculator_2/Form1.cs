using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseOpe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = 0;
            try
            {
                double a = Convert.ToDouble(inputNum1.Text);
                double b = Convert.ToDouble(inputNum2.Text);
                String x = chooseOpe.Text;
                switch (x)
                {
                    case "+":
                        c = a + b;
                        break;
                    case "-":
                        c = a - b;
                        break;
                    case "*":
                        c = a * b;
                        break;
                    case "/":
                        if (b == 0)
                        {
                            answer.Text = "除数不能为0";
                            return;
                        }
                        c = a / b;
                        break;
                }
            }
            catch (Exception x)
            {
                answer.Text = "输入有误";
                return;
            }
            answer.Text = $"{c}";
        }
    }
}
