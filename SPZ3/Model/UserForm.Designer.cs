namespace SPZ3
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ok = new System.Windows.Forms.Button();
            this.UName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.PList = new System.Windows.Forms.Label();
            this.listBoxProg = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.Location = new System.Drawing.Point(155, 168);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 50);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // UName
            // 
            this.UName.AutoSize = true;
            this.UName.Location = new System.Drawing.Point(10, 9);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(29, 13);
            this.UName.TabIndex = 1;
            this.UName.Text = "Имя";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(114, 9);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(45, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Пароль";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(11, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(117, 25);
            this.textBoxPassword.MaxLength = 8;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // PList
            // 
            this.PList.AutoSize = true;
            this.PList.Location = new System.Drawing.Point(10, 58);
            this.PList.Name = "PList";
            this.PList.Size = new System.Drawing.Size(98, 13);
            this.PList.TabIndex = 5;
            this.PList.Text = "Список программ";
            // 
            // listBoxProg
            // 
            this.listBoxProg.FormattingEnabled = true;
            this.listBoxProg.Location = new System.Drawing.Point(8, 84);
            this.listBoxProg.Name = "listBoxProg";
            this.listBoxProg.Size = new System.Drawing.Size(103, 134);
            this.listBoxProg.TabIndex = 9;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 226);
            this.Controls.Add(this.listBoxProg);
            this.Controls.Add(this.PList);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UName);
            this.Controls.Add(this.Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label UName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label PList;
        private System.Windows.Forms.ListBox listBoxProg;
    }
}