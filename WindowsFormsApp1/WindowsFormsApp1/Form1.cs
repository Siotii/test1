using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
            
                int firstNum = int.Parse(textBox1.Text);
                int secondNum = int.Parse(textBox2.Text);
                int result = 0;

                if (radioButton1.Checked)
                {
                    result = firstNum + secondNum;
                }
                else if (radioButton2.Checked)
                {
                    result = firstNum - secondNum;
                }
                else if (radioButton3.Checked)
                {
                    result = firstNum * secondNum;
                }
                else if (radioButton4.Checked)
                {

                    result = firstNum / secondNum;
                }
            }
        }
    }
}
    

