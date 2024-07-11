using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Task15 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private List<double> lastBooking = new List<double>();
        double currentAmount = 0;

        private void Form1_Load(object sender, EventArgs e) {
            label1.Text = "Current Amount:";
            label2.Text = "Last booking:";
            label3.Text = "Amount to book:";
            button1.Text = "Book";

            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e) {
        }

        private void label2_Click(object sender, EventArgs e) {
        }

        private void label3_Click(object sender, EventArgs e) {
        }

        private void button1_Click(object sender, EventArgs e) {
            var amount = textBox1.Text;

            lastBooking.Add(Convert.ToDouble(amount));
            currentAmount += Convert.ToDouble(amount);

            textBox3.Text = currentAmount.ToString();
            textBox2.Text = lastBooking.Last().ToString();
        }
    }
}
