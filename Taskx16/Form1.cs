using System;
using System.Drawing;
using System.Windows.Forms;

namespace Taskx16 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        double[] days = new double[366];
        int currentDay;
        double average;
        double limit = 50;
        int violations;
        int maxViolations = 35;
        double bestDay;
        double worstDay;

        private void Form1_Load(object sender, EventArgs e) {
            label2.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            label3.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            label4.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            label5.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            label6.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            label7.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            button1.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            button2.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            button3.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            button4.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            button5.Font = new Font("Segoe UI", 8, FontStyle.Regular);

            richTextBox1.Font = new Font("Segoe UI", 20, FontStyle.Regular);
            richTextBox2.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            button1.

            Text = "Feinstaub Mess Tool";

            label2.Text = "Heutige Werte: -";
            label3.Text = "Durchschnittswerte: " + average;
            label4.Text = "Grenzwert: " + limit;
            label5.Text = "Grenzwertüberschreitungen: " + violations + " / " + maxViolations;
            label6.Text = "Geringste Messung: " + bestDay;
            label7.Text = "Höchste Messung: " + worstDay;

            button1.Text = "Messwert hinzufügen";
            button2.Text = "Bisherige Messungen ausgeben";
            button3.Text = "Zurücksetzen";
            button4.Text = "Korrektur";
            button5.Text = "Generate Values";

            richTextBox1.Text = "";
            richTextBox2.Text = "";

            richTextBox1.Focus();
            richTextBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e) {
            double day;
            try {
                day = Convert.ToDouble(richTextBox1.Text);
            } catch (Exception _) {
                MessageBox.Show("Ungültige Eingabe!");
                return;
            }

            days[currentDay] = day;
            currentDay++;

            richTextBox1.Text = "";

            calcValues(day);
        }

        private void calcValues(double lastDay) {
            if (lastDay > limit) {
                violations++;
                label5.Text = "Grenzwertüberschreitungen: " + violations.ToString() + " / " + maxViolations.ToString();
            }

            if (days.Length > 0) {
                double allDays = 0;
                for (var i = 0; i < days.Length; i++) {
                    allDays += days[i];
                }

                average = allDays / currentDay;

                label3.Text = "Durchschnittswerte: " + average.ToString("0.00");
            }

            label2.Text = "Heutige Werte: " + Math.Round(lastDay, 2);

            if (violations == maxViolations) {
                MessageBox.Show("Grenzwertüberschreitungen überschritten!");
            }

            if (lastDay < bestDay || bestDay == 0) {
                bestDay = Convert.ToInt32(lastDay);
                label6.Text = "Geringste Messung: " + Math.Round(bestDay, 2) + " on day " + currentDay;
            }

            if (lastDay > worstDay || worstDay == 0) {
                worstDay = Convert.ToInt32(lastDay);
                label7.Text = "Höchste Messung: " + Math.Round(worstDay, 2) + " on day " + currentDay;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            richTextBox2.Text = "";

            foreach (double day in days) {
                if (day == 0) {
                    continue;
                }

                richTextBox2.Text += day + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            currentDay = 0;
            average = 0;
            violations = 0;
            bestDay = 0;
            worstDay = 0;

            for (int i = 0; i < days.Length; i++) {
                days[i] = 0;
            }

            label2.Text = "Heutige Werte: -";
            label3.Text = "Durchschnittswerte: " + average;
            label5.Text = "Grenzwertüberschreitungen: " + violations + " / " + maxViolations;
            label6.Text = "Geringste Messung: " + bestDay;
            label7.Text = "Höchste Messung: " + worstDay;

            richTextBox1.Text = "";
            richTextBox2.Text = "";

            richTextBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e) {
            if (currentDay > 0) {
                currentDay--;

                if (richTextBox1.Text == "") {
                    return;
                }

                double lastDay;
                try {
                    lastDay = Convert.ToDouble(richTextBox1.Text);
                } catch (Exception _) {
                    MessageBox.Show("Ungültige Eingabe!");
                    return;
                }

                days[currentDay] = lastDay;

                richTextBox1.Text = "";

                calcValues(lastDay);
            }   
        }

        private void button5_Click(object sender, EventArgs e) {
            var random = new Random();

            for (var i = 0; i < 100; i++) {
                var randomValue = random.NextDouble() * (100 - 0) + 0;

                if (currentDay > days.Length) {
                    break;
                }

                days[currentDay] = Math.Round(randomValue, 2);
                currentDay++;

                calcValues(randomValue);
            }
        }
    }
}
