using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tabnametest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewTabButton_Click(object sender, EventArgs e)
        {
            UserControl1 usercontrol = new UserControl1();
            usercontrol.Dock = DockStyle.Fill;
            TabPage newTabPage = new TabPage("new tab");
            newTabPage.Controls.Add(usercontrol);
            tabControl1.TabPages.Add(newTabPage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl1 usercontrol = new UserControl1();
            tabControl1.SelectedTab.Text = usercontrol.textBox1.Text;
        }
    }
}
