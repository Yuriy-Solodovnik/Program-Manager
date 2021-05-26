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
    public partial class DeletePForm : Form
    {
        private string[] _mas;
        public DeletePForm()
        {
            InitializeComponent();
            for (int i = 0; i < Store.LPrograms.Count; i++)
            {
                checkedListBoxP.Items.Add(Store.LPrograms[i].Name);
            }
        }
        private void ch()
        {
            _mas = new string[checkedListBoxP.CheckedItems.Count];
            for (int i = 0; i < checkedListBoxP.CheckedItems.Count; i++)
            {
                _mas[i] = checkedListBoxP.CheckedItems[i].ToString();
            }
        }
        private void checkedListBoxP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxP.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBoxP.Items.Count; i++)
                    checkedListBoxP.SetItemChecked(i, false);
                checkedListBoxP.SetItemChecked(checkedListBoxP.SelectedIndex, true);
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            ch();
            for (int i = 0; i < checkedListBoxP.Items.Count; i++)
            {
                for (int j = 0; j < checkedListBoxP.CheckedItems.Count; j++)
                {
                    if (checkedListBoxP.Items[i].ToString() == _mas[j])
                    {
                        Store.RemoveProgram(i);
                    }
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
