namespace SPZ3
{
    partial class DeletePForm
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
            this.Delete = new System.Windows.Forms.Button();
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
            this.checkedListBoxP.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(138, 159);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeletePForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 216);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.checkedListBoxP);
            this.Name = "DeletePForm";
            this.Text = "DeletePForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxP;
        private System.Windows.Forms.Button Delete;
    }
}