using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ3
{
    public partial class DeleteUform : Form
    {
        public DeleteUform()
        {
            InitializeComponent();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (Store.RemoveUser(textBoxNameU.Text, textBoxPasswordVerificator.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Неверные данные");
                return;
            }

        }
    }
}
