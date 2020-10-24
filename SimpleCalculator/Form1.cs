using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAnswer mdAdd = new GetAnswer(Formula.getSum);


            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(mdAdd(num1, num2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAnswer mdSub = new GetAnswer(Formula.getDiff);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(mdSub(num1, num2).ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetAnswer mdMulti = new GetAnswer(Formula.getProduct);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(mdMulti(num1, num2).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetAnswer mdDiv = new GetAnswer(Formula.getQuotient);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(mdDiv(num1, num2).ToString());
        }
    }
}
