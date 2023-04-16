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
    public partial class Sale : Form
    {
        Form1 MainWindow;
        public Sale(Form1 mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
        }
    }
}
