using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabnametest
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            textBox1.GotFocus += Focus;
            textBox1.LostFocus += LostFocus;

        }
        public void Focus(object sender, EventArgs e) { if (textBox1.Text == "Enter New Tab name here") { textBox1.Text = ""; textBox1.ForeColor = Color.Black; } }
        public void LostFocus(object sender, EventArgs e) { if (String.IsNullOrWhiteSpace(textBox1.Text)) { textBox1.Text = "Enter New Tab name here"; textBox1.ForeColor = Color.Gray; } }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.tabControl1.SelectedTab.Text = textBox1.Text;
        }
    }
}
