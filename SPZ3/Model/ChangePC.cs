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
    public partial class ChangePC : Form
    {
        public ChangePC()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            Store.pc.RemoveAt(0);
            PC pp = new PC();
            pp.CP = (double)numericUpDownCP.Value;
            pp.RAM = (int)numericUpDownRAM.Value;
            pp.HDD = (int)numericUpDownHDD.Value;
            Store.pc.Add(pp);
            Store.IsAvalible(pp);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
