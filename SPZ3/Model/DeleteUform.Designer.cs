namespace SPZ3
{
    partial class DeleteUform
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
            this.Delete = new System.Windows.Forms.Button();
            this.textBoxPasswordVerificator = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.labelNameU = new System.Windows.Forms.Label();
            this.textBoxNameU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(163, 181);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // textBoxPasswordVerificator
            // 
            this.textBoxPasswordVerificator.Location = new System.Drawing.Point(0, 100);
            this.textBoxPasswordVerificator.MaxLength = 8;
            this.textBoxPasswordVerificator.Name = "textBoxPasswordVerificator";
            this.textBoxPasswordVerificator.PasswordChar = '*';
            this.textBoxPasswordVerificator.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasswordVerificator.TabIndex = 5;
            this.textBoxPasswordVerificator.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(1, 81);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(115, 13);
            this.Password.TabIndex = 6;
            this.Password.Text = "Подтвердите пароль ";
            // 
            // labelNameU
            // 
            this.labelNameU.AutoSize = true;
            this.labelNameU.Location = new System.Drawing.Point(1, 19);
            this.labelNameU.Name = "labelNameU";
            this.labelNameU.Size = new System.Drawing.Size(146, 13);
            this.labelNameU.TabIndex = 8;
            this.labelNameU.Text = "Введите имя пользователя";
            // 
            // textBoxNameU
            // 
            this.textBoxNameU.Location = new System.Drawing.Point(0, 38);
            this.textBoxNameU.MaxLength = 8;
            this.textBoxNameU.Name = "textBoxNameU";
            this.textBoxNameU.Size = new System.Drawing.Size(105, 20);
            this.textBoxNameU.TabIndex = 7;
            // 
            // DeleteUform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 216);
            this.Controls.Add(this.labelNameU);
            this.Controls.Add(this.textBoxNameU);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBoxPasswordVerificator);
            this.Controls.Add(this.Delete);
            this.Name = "DeleteUform";
            this.Text = "DeleteUform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox textBoxPasswordVerificator;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label labelNameU;
        private System.Windows.Forms.TextBox textBoxNameU;
    }
}