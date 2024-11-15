namespace Basy
{
    partial class ChooseTagsToSort
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
            this.btnSort = new System.Windows.Forms.Button();
            this.lblChooseTags = new System.Windows.Forms.Label();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Location = new System.Drawing.Point(12, 401);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(91, 35);
            this.btnSort.TabIndex = 16;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblChooseTags
            // 
            this.lblChooseTags.AutoSize = true;
            this.lblChooseTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseTags.Location = new System.Drawing.Point(12, 15);
            this.lblChooseTags.Name = "lblChooseTags";
            this.lblChooseTags.Size = new System.Drawing.Size(223, 24);
            this.lblChooseTags.TabIndex = 15;
            this.lblChooseTags.Text = "Please select Tags to sort";
            // 
            // lbTags
            // 
            this.lbTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 24;
            this.lbTags.Location = new System.Drawing.Point(12, 67);
            this.lbTags.Name = "lbTags";
            this.lbTags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTags.Size = new System.Drawing.Size(330, 316);
            this.lbTags.TabIndex = 17;
            // 
            // ChooseTagsToSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.lbTags);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblChooseTags);
            this.Name = "ChooseTagsToSort";
            this.Text = "ChooseTagsToSort";
            this.Load += new System.EventHandler(this.ChooseTagsToSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblChooseTags;
        private System.Windows.Forms.ListBox lbTags;
    }
}