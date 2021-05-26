namespace SPZ3
{
    partial class UpdateForm
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
            this.checkedListBoxP = new System.Windows.Forms.CheckedListBox();
            this.labelNewVersion = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.numericUpDownNewVersion = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxP
            // 
            this.checkedListBoxP.CheckOnClick = true;
            this.checkedListBoxP.FormattingEnabled = true;
            this.checkedListBoxP.Location = new System.Drawing.Point(13, 13);
            this.checkedListBoxP.Name = "checkedListBoxP";
            this.checkedListBoxP.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxP.TabIndex = 0;
            // 
            // labelNewVersion
            // 
            this.labelNewVersion.AutoSize = true;
            this.labelNewVersion.Location = new System.Drawing.Point(163, 13);
            this.labelNewVersion.Name = "labelNewVersion";
            this.labelNewVersion.Size = new System.Drawing.Size(78, 13);
            this.labelNewVersion.TabIndex = 1;
            this.labelNewVersion.Text = "Новая версия";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(185, 84);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // numericUpDownNewVersion
            // 
            this.numericUpDownNewVersion.DecimalPlaces = 2;
            this.numericUpDownNewVersion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownNewVersion.Location = new System.Drawing.Point(140, 30);
            this.numericUpDownNewVersion.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDownNewVersion.Name = "numericUpDownNewVersion";
            this.numericUpDownNewVersion.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNewVersion.TabIndex = 3;
            this.numericUpDownNewVersion.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 116);
            this.Controls.Add(this.numericUpDownNewVersion);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelNewVersion);
            this.Controls.Add(this.checkedListBoxP);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNewVersion;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.NumericUpDown numericUpDownNewVersion;
        private System.Windows.Forms.CheckedListBox checkedListBoxP;
    }
}