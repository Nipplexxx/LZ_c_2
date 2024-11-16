using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LZ_Sorbon
{
    public partial class Form6 : Form
    {
        private Panel customPanel;
        private Random random = new Random();
        public Form6()
        {
            InitializeComponent();
            this.Load += Form6_Load;
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            this.Text = "Добавление элементов управления";
            this.BackColor = System.Drawing.Color.White;
            customPanel = new Panel
            {
                BackColor = System.Drawing.Color.LightGray,
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(500, 300),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(customPanel);
            Button buttonAdd = new Button
            {
                Text = "Добавить элемент",
                Location = new System.Drawing.Point(10, 320),
                Size = new System.Drawing.Size(150, 30)
            };
            buttonAdd.Click += ButtonAdd_Click;
            this.Controls.Add(buttonAdd);
            Button buttonInfo = new Button
            {
                Text = "Показать информацию",
                Location = new System.Drawing.Point(170, 320),
                Size = new System.Drawing.Size(150, 30)
            };
            buttonInfo.Click += ButtonInfo_Click;
            this.Controls.Add(buttonInfo);
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Type[] controlTypes = { typeof(Button), typeof(Label), typeof(TextBox), typeof(CheckBox) };
            Type selectedType = controlTypes[random.Next(controlTypes.Length)];
            Control control;
            if (selectedType == typeof(Button))
            {
                control = new Button { Text = "Button" };
            }
            else if (selectedType == typeof(Label))
            {
                control = new Label { Text = "Label" };
            }
            else if (selectedType == typeof(TextBox))
            {
                control = new TextBox { Text = "TextBox" };
            }
            else
            {
                control = new CheckBox { Text = "CheckBox" };
            }
            control.Location = new System.Drawing.Point(
                random.Next(0, customPanel.Width - 100),
                random.Next(0, customPanel.Height - 30)
            );
            customPanel.Controls.Add(control);
        }
        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            if (customPanel == null)
            {
                MessageBox.Show("Панель не инициализирована.");
                return;
            }
            var controlList = customPanel.Controls.Cast<Control>().ToList();
            var controlCount = controlList
                .GroupBy(c => c.GetType().Name)
                .ToDictionary(g => g.Key, g => g.Count());
            string info = "Информация о добавленных элементах:\n";
            foreach (var pair in controlCount)
            {
                info += $"{pair.Key}: {pair.Value} шт.\n";
            }
            info += "\nРасположение элементов:\n";
            foreach (Control control in controlList)
            {
                info += $"{control.GetType().Name} - ({control.Location.X}, {control.Location.Y})\n";
            }
            MessageBox.Show(info, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
