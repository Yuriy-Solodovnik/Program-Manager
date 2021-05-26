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
    public partial class Form1 : Form
    {
        private readonly BindingSource _bsp;
        private readonly BindingSource _bsu;
        public Form1()
        {
            InitializeComponent();
            _bsp = new BindingSource();
            _bsu = new BindingSource();
            _bsp.DataSource = Store.LPrograms;
            dataGridViewPrograms.DataSource = _bsp;
            _bsu.DataSource = Store.Users.ToArray();
            dataGridViewUsers.DataSource = _bsu;
            dataGridViewUsers.Columns[1].Visible = false;
            PC p = new PC();
            Store.pc.Add(p);
            update();
        }
        private void update()
        {
            labelInfo.Text = $"Характеристики компютера: |CP={Store.pc[0].CP}| |RAM={Store.pc[0].RAM}| |HDD={Store.pc[0].HDD}|";
        }
        private void buttonInstalP_Click(object sender, EventArgs e)
        {
            Form form = new ProgramForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bsp.DataSource = Store.LPrograms;
                _bsp.ResetBindings(false);
            }
        }

        private void buttonAddU_Click(object sender, EventArgs e)
        {
            Form form = new UserForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bsu.DataSource = Store.Users.ToArray();
                _bsu.ResetBindings(false);
            }
        }

        private void buttonUninstalP_Click(object sender, EventArgs e)
        {
            Form form = new DeletePForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bsp.DataSource = Store.LPrograms;
                _bsp.ResetBindings(false);
            }
        }

        private void buttonUpdateP_Click(object sender, EventArgs e)
        {
            Form form = new UpdateForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bsp.DataSource = Store.LPrograms;
                _bsp.ResetBindings(false);
            }
        }

        private void buttonDeleteU_Click(object sender, EventArgs e)
        {
            Form form = new DeleteUform();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bsu.DataSource = Store.Users.ToArray();
                _bsu.ResetBindings(false);
            }
        }

        private void CompareP_Click(object sender, EventArgs e)
        {
            Form form = new CompareP();
            form.ShowDialog();
        }
        private void buttonCompareU_Click(object sender, EventArgs e)
        {
            Form form = new CompareU();
            form.ShowDialog();
        }
        private void dataGridViewPrograms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var program = Store.LPrograms[index];
            Form form = new ProgramForm(program, index);
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bsp.ResetBindings(false);
            }
        }
        private void labelInfo_DoubleClick(object sender, EventArgs e)
        {
            Form form = new ChangePC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                update();
                _bsp.ResetBindings(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new AddProgramToUser();
            form.ShowDialog();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            var user = Store.Users[dataGridViewUsers.CurrentCell.Value.ToString()];
            Form form = new UserForm(user);
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bsp.ResetBindings(false);
            }
        }
    }
}
