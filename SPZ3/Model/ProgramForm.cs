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
    public partial class ProgramForm : Form
    {
        bool update = false;
        int index;
        public ProgramForm()
        {
            InitializeComponent();
        }
        public ProgramForm(Programs program, int index)
        {
            InitializeComponent();
            update = true;
            textBoxName.Text = program.Name;
            textBoxOS.Text = program.OS;
            textBoxMaker.Text = program.Maker;
            numericUpDownVersion.Value = (decimal)program.Version;
            numericUpDownRAM.Value = (decimal)program.RAM;
            numericUpDownCP.Value = (decimal)program.CP;
            numericUpDownHDD.Value = (decimal)program.HDD;
            Avalible.Checked = program.Avalible;
            this.index = index;
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Programs p = new Programs();
            p.Name = textBoxName.Text;
            p.OS = textBoxOS.Text;
            p.Maker = textBoxMaker.Text;
            p.Version = (double)numericUpDownVersion.Value;
            p.RAM = (int)numericUpDownRAM.Value;
            p.CP = (double)numericUpDownCP.Value;
            p.HDD = (int)numericUpDownHDD.Value;
            p.InstalDate = dateTimePicker.Value;
            p.Avalible = Avalible.Checked;
            if (update)
            {
                Store.RemoveProgram(index);
                Store.LPrograms.Insert(index, p);
            }
            else
                Store.AddProgram(p);
            update = false;
            Close();
        }
    }
}
