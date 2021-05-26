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
    public partial class CompareP : Form
    {
        public CompareP()
        {
            InitializeComponent();
            for (int i = 0; i < Store.LPrograms.Count; i++)
            {
                checkedListBoxP1.Items.Add(Store.LPrograms[i].Name);
                checkedListBoxP2.Items.Add(Store.LPrograms[i].Name);
            }
        }
        int check(CheckedListBox c)
        {
            int s = -1;
            foreach (int i in c.CheckedIndices)
            {
                s = i;
            }
            return s;
        }
        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if (Store.LPrograms.Count > 0)
            {
                if (Store.LPrograms[check(checkedListBoxP1)] > Store.LPrograms[check(checkedListBoxP2)])
                {
                    MessageBox.Show($"{Store.LPrograms[check(checkedListBoxP1)].Name} программа более требовательная");
                }
                else if (Store.LPrograms[check(checkedListBoxP1)] < Store.LPrograms[check(checkedListBoxP2)])
                {
                    MessageBox.Show($"{Store.LPrograms[check(checkedListBoxP2)].Name} программа более требовательная");
                }
                else 
                    MessageBox.Show("Нельзя определить точно");
                Close();
            }
        }
    }
}
