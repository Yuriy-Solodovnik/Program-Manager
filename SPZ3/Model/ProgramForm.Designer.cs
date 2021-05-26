namespace SPZ3
{
    partial class ProgramForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.PName = new System.Windows.Forms.Label();
            this.OS = new System.Windows.Forms.Label();
            this.textBoxOS = new System.Windows.Forms.TextBox();
            this.Maker = new System.Windows.Forms.Label();
            this.textBoxMaker = new System.Windows.Forms.TextBox();
            this.InstalDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownVersion = new System.Windows.Forms.NumericUpDown();
            this.Version = new System.Windows.Forms.Label();
            this.RAM = new System.Windows.Forms.Label();
            this.numericUpDownRAM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHDD = new System.Windows.Forms.NumericUpDown();
            this.HDD = new System.Windows.Forms.Label();
            this.numericUpDownCP = new System.Windows.Forms.NumericUpDown();
            this.CP = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.Avalible = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCP)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(18, 45);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(68, 26);
            this.textBoxName.TabIndex = 0;
            // 
            // PName
            // 
            this.PName.AutoSize = true;
            this.PName.Location = new System.Drawing.Point(14, 9);
            this.PName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(83, 20);
            this.PName.TabIndex = 1;
            this.PName.Text = "Название";
            // 
            // OS
            // 
            this.OS.AutoSize = true;
            this.OS.Location = new System.Drawing.Point(119, 9);
            this.OS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OS.Name = "OS";
            this.OS.Size = new System.Drawing.Size(32, 20);
            this.OS.TabIndex = 3;
            this.OS.Text = "ОС";
            // 
            // textBoxOS
            // 
            this.textBoxOS.Location = new System.Drawing.Point(117, 45);
            this.textBoxOS.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxOS.Name = "textBoxOS";
            this.textBoxOS.Size = new System.Drawing.Size(68, 26);
            this.textBoxOS.TabIndex = 2;
            // 
            // Maker
            // 
            this.Maker.AutoSize = true;
            this.Maker.Location = new System.Drawing.Point(212, 9);
            this.Maker.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Maker.Name = "Maker";
            this.Maker.Size = new System.Drawing.Size(117, 20);
            this.Maker.TabIndex = 5;
            this.Maker.Text = "Изготовитель";
            // 
            // textBoxMaker
            // 
            this.textBoxMaker.Location = new System.Drawing.Point(216, 45);
            this.textBoxMaker.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxMaker.Name = "textBoxMaker";
            this.textBoxMaker.Size = new System.Drawing.Size(119, 26);
            this.textBoxMaker.TabIndex = 4;
            // 
            // InstalDate
            // 
            this.InstalDate.AutoSize = true;
            this.InstalDate.Location = new System.Drawing.Point(14, 216);
            this.InstalDate.Name = "InstalDate";
            this.InstalDate.Size = new System.Drawing.Size(139, 20);
            this.InstalDate.TabIndex = 6;
            this.InstalDate.Text = "Время установки";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(18, 239);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(167, 26);
            this.dateTimePicker.TabIndex = 7;
            // 
            // numericUpDownVersion
            // 
            this.numericUpDownVersion.DecimalPlaces = 2;
            this.numericUpDownVersion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownVersion.Location = new System.Drawing.Point(18, 99);
            this.numericUpDownVersion.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDownVersion.Name = "numericUpDownVersion";
            this.numericUpDownVersion.Size = new System.Drawing.Size(76, 26);
            this.numericUpDownVersion.TabIndex = 8;
            this.numericUpDownVersion.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(14, 76);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(64, 20);
            this.Version.TabIndex = 9;
            this.Version.Text = "Версия";
            // 
            // RAM
            // 
            this.RAM.AutoSize = true;
            this.RAM.Location = new System.Drawing.Point(119, 76);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(45, 20);
            this.RAM.TabIndex = 10;
            this.RAM.Text = "RAM";
            // 
            // numericUpDownRAM
            // 
            this.numericUpDownRAM.Increment = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownRAM.Location = new System.Drawing.Point(117, 99);
            this.numericUpDownRAM.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownRAM.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownRAM.Name = "numericUpDownRAM";
            this.numericUpDownRAM.Size = new System.Drawing.Size(76, 26);
            this.numericUpDownRAM.TabIndex = 11;
            this.numericUpDownRAM.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericUpDownHDD
            // 
            this.numericUpDownHDD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownHDD.Location = new System.Drawing.Point(117, 168);
            this.numericUpDownHDD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownHDD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownHDD.Name = "numericUpDownHDD";
            this.numericUpDownHDD.Size = new System.Drawing.Size(76, 26);
            this.numericUpDownHDD.TabIndex = 13;
            this.numericUpDownHDD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // HDD
            // 
            this.HDD.AutoSize = true;
            this.HDD.Location = new System.Drawing.Point(119, 145);
            this.HDD.Name = "HDD";
            this.HDD.Size = new System.Drawing.Size(45, 20);
            this.HDD.TabIndex = 12;
            this.HDD.Text = "HDD";
            // 
            // numericUpDownCP
            // 
            this.numericUpDownCP.DecimalPlaces = 2;
            this.numericUpDownCP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownCP.Location = new System.Drawing.Point(18, 168);
            this.numericUpDownCP.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCP.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.numericUpDownCP.Name = "numericUpDownCP";
            this.numericUpDownCP.Size = new System.Drawing.Size(76, 26);
            this.numericUpDownCP.TabIndex = 15;
            this.numericUpDownCP.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            // 
            // CP
            // 
            this.CP.AutoSize = true;
            this.CP.Location = new System.Drawing.Point(14, 145);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(42, 20);
            this.CP.TabIndex = 14;
            this.CP.Text = "CPU";
            // 
            // Ok
            // 
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.Location = new System.Drawing.Point(222, 199);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(113, 66);
            this.Ok.TabIndex = 16;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Avalible
            // 
            this.Avalible.AutoSize = true;
            this.Avalible.Checked = true;
            this.Avalible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Avalible.Location = new System.Drawing.Point(216, 100);
            this.Avalible.Name = "Avalible";
            this.Avalible.Size = new System.Drawing.Size(126, 24);
            this.Avalible.TabIndex = 17;
            this.Avalible.Text = "Доступность";
            this.Avalible.UseVisualStyleBackColor = true;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 277);
            this.Controls.Add(this.Avalible);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.numericUpDownCP);
            this.Controls.Add(this.CP);
            this.Controls.Add(this.numericUpDownHDD);
            this.Controls.Add(this.HDD);
            this.Controls.Add(this.numericUpDownRAM);
            this.Controls.Add(this.RAM);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.numericUpDownVersion);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.InstalDate);
            this.Controls.Add(this.Maker);
            this.Controls.Add(this.textBoxMaker);
            this.Controls.Add(this.OS);
            this.Controls.Add(this.textBoxOS);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProgramForm";
            this.Text = "Программа";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label PName;
        private System.Windows.Forms.Label OS;
        private System.Windows.Forms.TextBox textBoxOS;
        private System.Windows.Forms.Label Maker;
        private System.Windows.Forms.TextBox textBoxMaker;
        private System.Windows.Forms.Label InstalDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown numericUpDownVersion;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label RAM;
        private System.Windows.Forms.NumericUpDown numericUpDownRAM;
        private System.Windows.Forms.NumericUpDown numericUpDownHDD;
        private System.Windows.Forms.Label HDD;
        private System.Windows.Forms.NumericUpDown numericUpDownCP;
        private System.Windows.Forms.Label CP;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.CheckBox Avalible;
    }
}