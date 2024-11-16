using System;
using System.Linq;
using System.Windows.Forms;

namespace LZ_Sorbon
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void CountLowercaseRussianLetters(string input)
        {
            var lowercaseRussianLetters = "аеиоуыёюябвгдежзийклмнопрстуфхцчшщъыьэюя".ToArray();
            int count = input.Count(c => lowercaseRussianLetters.Contains(c));
            var resultLabel = this.Controls.Find("resultLabel", true).FirstOrDefault() as Label;
            if (resultLabel != null)
            {
                resultLabel.Text = $"Количество строчных русских букв: {count}";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
        private void Form7_Load_1(object sender, EventArgs e)
        {
            this.Text = "Подсчет строчных русских букв";
            TextBox inputTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(300, 30),
                Name = "inputTextBox"
            };
            this.Controls.Add(inputTextBox);
            Button countButton = new Button
            {
                Text = "Подсчитать",
                Location = new System.Drawing.Point(10, 50),
                Size = new System.Drawing.Size(100, 30)
            };
            countButton.Click += (s, eventArgs) => CountLowercaseRussianLetters(inputTextBox.Text);
            this.Controls.Add(countButton);
            Label resultLabel = new Label
            {
                Location = new System.Drawing.Point(10, 90),
                Size = new System.Drawing.Size(300, 30),
                Name = "resultLabel"
            };
            this.Controls.Add(resultLabel);
        }
    }
}
