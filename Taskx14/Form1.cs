using System;
using System.Windows.Forms;

namespace Taskx14 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            checkedListBox1.Items.Add("3%");
            checkedListBox1.Items.Add("5%");

            webBrowser1.Navigate("https://google.com");
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {

        }
    }
}
