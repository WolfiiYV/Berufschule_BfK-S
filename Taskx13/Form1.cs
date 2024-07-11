using System;
using System.Text;
using System.Windows.Forms;

namespace Taskx13 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Text = "1x1";
            label1.Text = "1x1 für:";
            button1.Text = "Berechnen";
            button2.Text = "Löschen";
            button3.Text = "Beenden";

            richTextBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            var input = richTextBox1.Text;
            if (input.Length == 0) {
                richTextBox2.Text = "Bitte geben Sie eine Zahl ein!";
                return;
            }

            int number;
            if (!int.TryParse(input, out number)) {
                richTextBox2.Text = "Bitte geben Sie eine gültige Zahl ein!";
                return;
            }

            var result = new StringBuilder();
            for (int i = 1; i <= 10; i++) {
                result.AppendLine($"{i} x {number} = {i * number}");
            }
            richTextBox2.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
