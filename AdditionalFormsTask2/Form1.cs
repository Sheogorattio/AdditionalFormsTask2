using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalFormsTask2
{
    public partial class Form1 : Form
    {
        public List<PC> PcList = new List<PC>();
        public Form1()
        {
            InitializeComponent();
            this.Text = "MainWindow";
            this.button1.Text = "Buy";
            this.button2.Text = "Edit(Admin mode)";
            this.button3.Text = "Exit";
        }

        private void button1_Click(object sender, EventArgs e)//buy buttton
        {
            Sale wnd = new Sale(this);
            wnd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminCheck wnd = new AdminCheck(this);
            wnd.ShowDialog();
        }
    }
}
