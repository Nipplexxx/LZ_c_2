using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace LZ_Sorbon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void buttonHide_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            label1.Text = "Начало работы";
        }
    }
}
