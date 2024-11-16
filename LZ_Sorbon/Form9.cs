using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LZ_Sorbon
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
        private void Form9_Load_1(object sender, EventArgs e)
        {
            Random random = new Random();
            int[,] A = new int[10, 10];
            int max = int.MinValue;
            int maxRow = -1;
            int maxCol = -1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    A[i, j] = random.Next(-10, 11);
                    if (A[i, j] > max)
                    {
                        max = A[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            StringBuilder originalMatrix = new StringBuilder();
            originalMatrix.AppendLine("Исходная матрица:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    originalMatrix.Append(A[i, j].ToString().PadLeft(4));
                }
                originalMatrix.AppendLine();
            }
            int[,] modifiedMatrix = (int[,])A.Clone();
            for (int i = 0; i < 10; i++)
            {
                modifiedMatrix[maxRow, i] = 0;
                modifiedMatrix[i, maxCol] = 0;
            }
            StringBuilder modifiedMatrixText = new StringBuilder();
            modifiedMatrixText.AppendLine("Измененная матрица:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    modifiedMatrixText.Append(modifiedMatrix[i, j].ToString().PadLeft(4));
                }
                modifiedMatrixText.AppendLine();
            }
            MessageBox.Show($"Наибольший элемент: {max}\n{originalMatrix}\n{modifiedMatrixText}",
                "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
