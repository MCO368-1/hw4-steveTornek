using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTempConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                double result = Utilities.UniversalConversion(Double.Parse(textBox1.Text),
                    (TempUnit) comboBox1.SelectedIndex,
                    (TempUnit) comboBox2.SelectedIndex);
                label3.Text = result.ToString("F2");
                label3.ForeColor = Color.Black;

            }
            else
            {
                label3.Text = "Invalid Input";
                label3.ForeColor = Color.Red;

            }
        }

        private bool CheckInput()
        {
            double num;
            if (textBox1.Text.Length == 0)
            {
                return false;
            }
            if (Double.TryParse(textBox1.Text, out num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
    }
}
