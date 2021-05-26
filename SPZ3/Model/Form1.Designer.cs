namespace SPZ3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPrograms = new System.Windows.Forms.DataGridView();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonInstalP = new System.Windows.Forms.Button();
            this.buttonUninstalP = new System.Windows.Forms.Button();
            this.buttonUpdateP = new System.Windows.Forms.Button();
            this.buttonAddU = new System.Windows.Forms.Button();
            this.buttonDeleteU = new System.Windows.Forms.Button();
            this.buttonCompareU = new System.Windows.Forms.Button();
            this.CompareP = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Программы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1037, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пользователи";
            // 
            // dataGridViewPrograms
            // 
            this.dataGridViewPrograms.AllowUserToAddRows = false;
            this.dataGridViewPrograms.AllowUserToDeleteRows = false;
            this.dataGridViewPrograms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrograms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrograms.Location = new System.Drawing.Point(13, 37);
            this.dataGridViewPrograms.Name = "dataGridViewPrograms";
            this.dataGridViewPrograms.ReadOnly = true;
            this.dataGridViewPrograms.Size = new System.Drawing.Size(956, 284);
            this.dataGridViewPrograms.TabIndex = 2;
            this.dataGridViewPrograms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrograms_CellContentClick);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(975, 37);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(249, 284);
            this.dataGridViewUsers.TabIndex = 3;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // buttonInstalP
            // 
            this.buttonInstalP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInstalP.Location = new System.Drawing.Point(13, 340);
            this.buttonInstalP.Name = "buttonInstalP";
            this.buttonInstalP.Size = new System.Drawing.Size(110, 33);
            this.buttonInstalP.TabIndex = 4;
            this.buttonInstalP.Text = "Инсталяция";
            this.buttonInstalP.UseVisualStyleBackColor = true;
            this.buttonInstalP.Click += new System.EventHandler(this.buttonInstalP_Click);
            // 
            // buttonUninstalP
            // 
            this.buttonUninstalP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUninstalP.Location = new System.Drawing.Point(129, 340);
            this.buttonUninstalP.Name = "buttonUninstalP";
            this.buttonUninstalP.Size = new System.Drawing.Size(136, 33);
            this.buttonUninstalP.TabIndex = 5;
            this.buttonUninstalP.Text = "Деинсталяция";
            this.buttonUninstalP.UseVisualStyleBackColor = true;
            this.buttonUninstalP.Click += new System.EventHandler(this.buttonUninstalP_Click);
            // 
            // buttonUpdateP
            // 
            this.buttonUpdateP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateP.Location = new System.Drawing.Point(12, 379);
            this.buttonUpdateP.Name = "buttonUpdateP";
            this.buttonUpdateP.Size = new System.Drawing.Size(111, 33);
            this.buttonUpdateP.TabIndex = 6;
            this.buttonUpdateP.Text = "Обновить";
            this.buttonUpdateP.UseVisualStyleBackColor = true;
            this.buttonUpdateP.Click += new System.EventHandler(this.buttonUpdateP_Click);
            // 
            // buttonAddU
            // 
            this.buttonAddU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddU.Location = new System.Drawing.Point(975, 325);
            this.buttonAddU.Name = "buttonAddU";
            this.buttonAddU.Size = new System.Drawing.Size(96, 48);
            this.buttonAddU.TabIndex = 7;
            this.buttonAddU.Text = "Добавить";
            this.buttonAddU.UseVisualStyleBackColor = true;
            this.buttonAddU.Click += new System.EventHandler(this.buttonAddU_Click);
            // 
            // buttonDeleteU
            // 
            this.buttonDeleteU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteU.Location = new System.Drawing.Point(1128, 325);
            this.buttonDeleteU.Name = "buttonDeleteU";
            this.buttonDeleteU.Size = new System.Drawing.Size(96, 48);
            this.buttonDeleteU.TabIndex = 8;
            this.buttonDeleteU.Text = "Удалить";
            this.buttonDeleteU.UseVisualStyleBackColor = true;
            this.buttonDeleteU.Click += new System.EventHandler(this.buttonDeleteU_Click);
            // 
            // buttonCompareU
            // 
            this.buttonCompareU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCompareU.Location = new System.Drawing.Point(1128, 379);
            this.buttonCompareU.Name = "buttonCompareU";
            this.buttonCompareU.Size = new System.Drawing.Size(96, 48);
            this.buttonCompareU.TabIndex = 9;
            this.buttonCompareU.Text = "Сравнить";
            this.buttonCompareU.UseVisualStyleBackColor = true;
            this.buttonCompareU.Click += new System.EventHandler(this.buttonCompareU_Click);
            // 
            // CompareP
            // 
            this.CompareP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompareP.Location = new System.Drawing.Point(129, 379);
            this.CompareP.Name = "CompareP";
            this.CompareP.Size = new System.Drawing.Size(136, 33);
            this.CompareP.TabIndex = 12;
            this.CompareP.Text = "Сравнить";
            this.CompareP.UseVisualStyleBackColor = true;
            this.CompareP.Click += new System.EventHandler(this.CompareP_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(0, 440);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(3);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Padding = new System.Windows.Forms.Padding(3);
            this.labelInfo.Size = new System.Drawing.Size(1236, 30);
            this.labelInfo.TabIndex = 13;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInfo.DoubleClick += new System.EventHandler(this.labelInfo_DoubleClick);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(397, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(361, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить программу к пользователю";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1236, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.CompareP);
            this.Controls.Add(this.buttonCompareU);
            this.Controls.Add(this.buttonDeleteU);
            this.Controls.Add(this.buttonAddU);
            this.Controls.Add(this.buttonUpdateP);
            this.Controls.Add(this.buttonUninstalP);
            this.Controls.Add(this.buttonInstalP);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.dataGridViewPrograms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Менеджер программ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPrograms;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonInstalP;
        private System.Windows.Forms.Button buttonUninstalP;
        private System.Windows.Forms.Button buttonUpdateP;
        private System.Windows.Forms.Button buttonAddU;
        private System.Windows.Forms.Button buttonDeleteU;
        private System.Windows.Forms.Button buttonCompareU;
        private System.Windows.Forms.Button CompareP;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button button1;
    }
}

