using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PanelForm
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
                {
                    int result = num1 / num2;
                    label5.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values in both text boxes.");
                }

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero");
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
            {
                int result = num1 - num2;
                label5.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values in both text boxes.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
            {
                int result = num1 + num2;
                label5.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values in both text boxes.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
            {
                int result = num1 * num2;
                label5.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values in both text boxes.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //number1text.Clear(); //it is also ok
            textBox2.Text = "";
            label5.Text = "";
        }
    }
}
