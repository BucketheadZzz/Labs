using System;
using System.Windows.Forms;

namespace Lab8
{
    public partial class LinkedForm : Form
    {
        public LinkedForm()
        {
            InitializeComponent();
        }

        private void coreValue_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(coreValue.Text, out var result))
            {
                linkedVal.Maximum = result;
                linkedVal.Text = result.ToString();
            }
        }
    }
}
