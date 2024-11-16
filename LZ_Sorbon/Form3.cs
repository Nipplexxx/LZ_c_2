using System;
using System.Windows.Forms;

namespace LZ_Sorbon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Вычисление fi";
            this.BackColor = System.Drawing.Color.LightYellow;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                double x = -2.235e-2;
                double y = 2.23;
                double z = 15.22;
                double numerator = Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Abs(x - y), Math.Abs(x + y));
                double denominator = Math.Atan(x) + Math.Atan(z);
                double firstTerm = numerator / denominator;
                double cubicRoot = Math.Pow(Math.Pow(x, 6) + Math.Pow(Math.Log(y), 2), 1.0 / 3.0);
                double fi = firstTerm + cubicRoot;
                labelResult.Text = $"Результат: fi = {fi:F3}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вычислении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
