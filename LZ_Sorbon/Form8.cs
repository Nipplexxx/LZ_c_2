using System;
using System.Linq;
using System.Windows.Forms;

namespace LZ_Sorbon
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
        private void Form8_Load_1(object sender, EventArgs e)
        {
            Random random = new Random();
            double[] A = new double[25];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.NextDouble() * 10 - 5;
            }
            int negativeCount = A.Count(x => x < 0);
            int inRangeCount = A.Count(x => x >= 1 && x <= 2);
            Label resultLabel = new Label
            {
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(300, 60),
                Text = $"Отрицательных элементов: {negativeCount}\nЧисел в отрезке [1,2]: {inRangeCount}"
            };
            this.Controls.Add(resultLabel);
        }
    }
}
