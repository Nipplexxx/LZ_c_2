using System;
using System.Windows.Forms;

namespace LZ_Sorbon
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = -0.75;
                double xk = -2.05;
                double dx = -0.2;
                if (dx == 0)
                {
                    throw new Exception("Шаг dx не может быть равен нулю.");
                }
                string result = "Результаты вычислений:\r\n";
                for (double x = x0; x >= xk; x += dx)
                {
                    double y = 9 * Math.Pow(x, 4) + Math.Sin(57.2 + x);
                    result += $"x = {x:F2}, y = {y:F4}\r\n";
                }
                textBoxResults.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
        private void Form5_Load_1(object sender, EventArgs e)
        {
            this.Text = "Вычисление функции y";
            this.BackColor = System.Drawing.Color.LightBlue;
        }
    }
}
