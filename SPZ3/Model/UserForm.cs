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
    public partial class UserForm : Form
    {
        Users u = new Users();
        bool update = false;
        public UserForm()
        {
            InitializeComponent();
            for(int i =0; i< u.getSize();i++)
            {
                listBoxProg.Items.Add(u.PRR[i].Name);
            }
        }
        public UserForm(Users user)
        {
            InitializeComponent();
            for (int i = 0; i < user.getSize(); i++)
            {
                listBoxProg.Items.Add(user.PRR[i].Name);
            }
            textBoxName.Text = user.Name;
            textBoxPassword.Text = user.Password;
            update = true;
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.TextLength < 8)
            {
                MessageBox.Show("Пароль должен содержать 8 символов");
            }
            else
            {
                if (update==true)
                {
                    DialogResult = DialogResult.OK;
                    update = false;
                    Close();
                    return;
                }
                u.Name = textBoxName.Text;
                u.Password = textBoxPassword.Text;
                Store.AddUser(u);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
