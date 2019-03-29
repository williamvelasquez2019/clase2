using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Un solo click";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "Dos click";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                label1.Text = "Selecciono el checkbox 1";
                radioButton1.Checked = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;

            }

            if (this.checkBox2.Checked == true)
            {
                label1.Text = "Selecciono el checkbox 2";
                radioButton2.Checked = true;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }

            if (this.checkBox3.Checked == true)
            {
                label1.Text = "Selecciono el checkbox 3";
                radioButton3.Checked = true;
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                checkBox4.Checked = false;
            }

            if (this.checkBox4.Checked == true)
            {
                label1.Text = "Selecciono el checkbox 4";
                radioButton4.Checked = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox1.Checked = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.radioButton1.Checked == true) 
            {
                label1.Text = "Selecciono el RadioBox 1 = Suma";

                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }

            if (this.radioButton2.Checked == true)
            {
                label1.Text = "Selecciono el RadioBox 2 = Resta";

                radioButton1.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }

            if (this.radioButton3.Checked == true)
            {
                label1.Text = "Selecciono el RadioBox 1 = Multiplicacion";

                radioButton2.Checked = false;
                radioButton1.Checked = false;
                radioButton4.Checked = false;
            }

            if (this.radioButton4.Checked == true)
            {
                label1.Text = "Selecciono el RadioBox 1 = Divison";

                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton1.Checked = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.BackColor = Color.Green;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                label1.BackColor = Color.Red;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                label1.BackColor = Color.Yellow;
            }

            if (comboBox1.SelectedIndex == 3)
            {
                label1.BackColor = Color.Green;
            }

            if (comboBox1.SelectedIndex == 4)
            {
                label1.BackColor = Color.Blue;
            }

            if (comboBox1.SelectedIndex == 5)
            {
                this.BackColor = System.Drawing.Color.Goldenrod;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
