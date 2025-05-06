using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedprovince = comboBox1.SelectedItem as string;
            List<string> Bagmati_districts = new List<string> { "Kathmandu", "Bhaktapur" };
            List<string> gandakiDistricts = new List<string> { "Kaski", "Lamjung", "Manang" };
            switch (selectedprovince)
            {
                case "Bagmati":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(Bagmati_districts.ToArray());
                    break;

                case "Gandaki":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(gandakiDistricts.ToArray());
                    break;
                default:
                    comboBox2.Items.Clear();
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //display a message saying registered:
            MessageBox.Show("Register button is clicked");
            //DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


        }
    }
}
