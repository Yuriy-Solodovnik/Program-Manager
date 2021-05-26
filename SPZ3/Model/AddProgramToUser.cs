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
    public partial class AddProgramToUser : Form
    {
        public AddProgramToUser()
        {
            InitializeComponent();
            for (int i = 0; i < Store.LPrograms.Count; i++)
            {
                if(Store.LPrograms[i].Avalible)
                checkedListBoxP1.Items.Add(Store.LPrograms[i].Name);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (var itemChecked in checkedListBoxP1.CheckedItems)
            { 
                    if (Store.Users.Keys.Contains(textBoxName.Text) && Store.Users[textBoxName.Text].Password == textBoxPassword.Text)
                    {
                        Store.Users[textBoxName.Text].PR = Store.LPrograms[checkedListBoxP1.Items.IndexOf(itemChecked)];
                        MessageBox.Show("Программа: \"" + itemChecked.ToString() + "\"добавлена.");
                    }
                    else
                    {
                        MessageBox.Show("Данные пользователя не совпадают");
                        return;
                    }
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
