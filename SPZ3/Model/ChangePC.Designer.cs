namespace SPZ3
{
    partial class ChangePC
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
            this.labelCh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.numericUpDownRAM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCP = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHDD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHDD)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCh
            // 
            this.labelCh.AutoSize = true;
            this.labelCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCh.Location = new System.Drawing.Point(49, 9);
            this.labelCh.Name = "labelCh";
            this.labelCh.Size = new System.Drawing.Size(336, 24);
            this.labelCh.TabIndex = 0;
            this.labelCh.Text = "Введите характеристики нового ПК";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "HDD";
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(352, 117);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 7;
            this.Accept.Text = "Принять";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // numericUpDownRAM
            // 
            this.numericUpDownRAM.Increment = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownRAM.Location = new System.Drawing.Point(178, 69);
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
            this.numericUpDownRAM.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownRAM.TabIndex = 12;
            this.numericUpDownRAM.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericUpDownCP
            // 
            this.numericUpDownCP.DecimalPlaces = 2;
            this.numericUpDownCP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownCP.Location = new System.Drawing.Point(12, 69);
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
            this.numericUpDownCP.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownCP.TabIndex = 16;
            this.numericUpDownCP.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            // 
            // numericUpDownHDD
            // 
            this.numericUpDownHDD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownHDD.Location = new System.Drawing.Point(351, 69);
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
            this.numericUpDownHDD.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownHDD.TabIndex = 17;
            this.numericUpDownHDD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ChangePC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 151);
            this.Controls.Add(this.numericUpDownHDD);
            this.Controls.Add(this.numericUpDownCP);
            this.Controls.Add(this.numericUpDownRAM);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCh);
            this.Name = "ChangePC";
            this.Text = "ChangePC";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.NumericUpDown numericUpDownRAM;
        private System.Windows.Forms.NumericUpDown numericUpDownCP;
        private System.Windows.Forms.NumericUpDown numericUpDownHDD;
    }
}