using System;
using System.Windows.Forms;

namespace LZ_Sorbon
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Вычисление j";
            this.BackColor = System.Drawing.Color.LightCyan;
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxX.Text);
                double m = double.Parse(textBoxM.Text);
                double f = double.Parse(textBoxF.Text);
                double j;
                if (-1 < m && m < x)
                {
                    j = Math.Sin(5 * f + 3 * m * Math.Abs(f));
                }
                else if (x > m)
                {
                    j = Math.Cos(3 * f + 5 * m * Math.Abs(f));
                }
                else if (x == m)
                {
                    j = Math.Pow(f + m, 2);
                }
                else
                {
                    throw new Exception("Значения не соответствуют условиям задачи.");
                }
                labelResult.Text = $"Результат: j = {j:F3}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
