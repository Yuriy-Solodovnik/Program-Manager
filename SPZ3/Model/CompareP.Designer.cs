namespace SPZ3
{
    partial class CompareP
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
            this.checkedListBoxP1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxP2 = new System.Windows.Forms.CheckedListBox();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxP1
            // 
            this.checkedListBoxP1.CheckOnClick = true;
            this.checkedListBoxP1.FormattingEnabled = true;
            this.checkedListBoxP1.Location = new System.Drawing.Point(13, 13);
            this.checkedListBoxP1.Name = "checkedListBoxP1";
            this.checkedListBoxP1.Size = new System.Drawing.Size(120, 184);
            this.checkedListBoxP1.TabIndex = 0;
            // 
            // checkedListBoxP2
            // 
            this.checkedListBoxP2.CheckOnClick = true;
            this.checkedListBoxP2.FormattingEnabled = true;
            this.checkedListBoxP2.Location = new System.Drawing.Point(220, 13);
            this.checkedListBoxP2.Name = "checkedListBoxP2";
            this.checkedListBoxP2.Size = new System.Drawing.Size(120, 184);
            this.checkedListBoxP2.TabIndex = 1;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(139, 13);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonCompare.TabIndex = 2;
            this.buttonCompare.Text = "Сравнить";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // CompareP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 205);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.checkedListBoxP2);
            this.Controls.Add(this.checkedListBoxP1);
            this.Name = "CompareP";
            this.Text = "CompareP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxP1;
        private System.Windows.Forms.CheckedListBox checkedListBoxP2;
        private System.Windows.Forms.Button buttonCompare;
    }
}