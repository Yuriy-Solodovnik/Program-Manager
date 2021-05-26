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
    public partial class CompareU : Form
    {
        public CompareU()
        {
            InitializeComponent();
            foreach( var i in Store.Users.Keys)
            {
                checkedListBoxU1.Items.Add(i);
                checkedListBoxU2.Items.Add(i);
            }
        }
        private int getIndex(CheckedListBox c)
        {
            foreach (int index in c.CheckedIndices)
                return index;
                return 0;
        }
        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if (Store.Users.Count > 0)
            {
                if (Store.Users[checkedListBoxU1.Items[getIndex(checkedListBoxU1)].ToString()] > Store.Users[checkedListBoxU1.Items[getIndex(checkedListBoxU2)].ToString()])
                {
                    MessageBox.Show($"{Store.Users[checkedListBoxU1.Items[getIndex(checkedListBoxU1)].ToString()].Name} имеет больше программ в списке");
                }
                else if (Store.Users[checkedListBoxU1.Items[getIndex(checkedListBoxU1)].ToString()] < Store.Users[checkedListBoxU1.Items[getIndex(checkedListBoxU2)].ToString()])
                {
                    MessageBox.Show($"{Store.Users[checkedListBoxU1.Items[getIndex(checkedListBoxU2)].ToString()].Name} имеет больше программ в списке");
                }
                else
                    MessageBox.Show("Пользователи равны");
                Close();
            }
        }
    }
}
