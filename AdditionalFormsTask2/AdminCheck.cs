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
    public partial class AdminCheck : Form
    {
        string login = "admin";
        string password = "adminadmin";
        Form1 MainWindow;
        public AdminCheck(Form1 MainWindow)
        {
            InitializeComponent();
            this.MainWindow = MainWindow;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if(login == LoginTextBox.Text && password == PasswordTextBox.Text) 
            {
                EditForm wnd = new EditForm(MainWindow);
                wnd.ShowDialog();
                wnd.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
