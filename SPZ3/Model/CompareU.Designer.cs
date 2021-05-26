namespace SPZ3
{
    partial class CompareU
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
            this.buttonCompare = new System.Windows.Forms.Button();
            this.checkedListBoxU2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxU1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(187, 56);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonCompare.TabIndex = 5;
            this.buttonCompare.Text = "Сравнить";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // checkedListBoxU2
            // 
            this.checkedListBoxU2.CheckOnClick = true;
            this.checkedListBoxU2.FormattingEnabled = true;
            this.checkedListBoxU2.Location = new System.Drawing.Point(268, 56);
            this.checkedListBoxU2.Name = "checkedListBoxU2";
            this.checkedListBoxU2.Size = new System.Drawing.Size(120, 184);
            this.checkedListBoxU2.TabIndex = 4;
            // 
            // checkedListBoxU1
            // 
            this.checkedListBoxU1.CheckOnClick = true;
            this.checkedListBoxU1.FormattingEnabled = true;
            this.checkedListBoxU1.Location = new System.Drawing.Point(61, 56);
            this.checkedListBoxU1.Name = "checkedListBoxU1";
            this.checkedListBoxU1.Size = new System.Drawing.Size(120, 184);
            this.checkedListBoxU1.TabIndex = 3;
            // 
            // CompareU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 300);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.checkedListBoxU2);
            this.Controls.Add(this.checkedListBoxU1);
            this.Name = "CompareU";
            this.Text = "CompareU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.CheckedListBox checkedListBoxU2;
        private System.Windows.Forms.CheckedListBox checkedListBoxU1;
    }
}