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
    public partial class EditForm : Form
    {
        Form1 MainWindow;
        ref PC selected;
        public EditForm(Form1 mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                selected = (from obj in MainWindow.PcList where obj.Name == this.listBox1.SelectedItem.ToString() select obj) as PC;
                BrandTextBox.Text = selected.Brand;
                CPUTextBox.Text = selected.CPU;
                GPUTextBox.Text = selected.GPU;
                RAMTextBox.Text = selected.RAM;
                MotherbTextBox.Text = selected.Motherb;
                SizeTextBox.Text = selected.Size;
                PriceTextBox.Text = selected.Price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected == null) { throw new Exception("Select an item."); }
                selected.Brand = BrandTextBox.Text;
                selected.CPU = CPUTextBox.Text;
                selected.GPU = GPUTextBox.Text;
                selected.RAM = RAMTextBox.Text;
                selected.Motherb = MotherbTextBox.Text;
                selected.Size = SizeTextBox.Text;
                selected.Price = Convert.ToDouble(PriceTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
