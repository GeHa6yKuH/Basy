namespace Basy
{
    partial class ChooseFromExistingTags
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
            this.btnAddTag = new System.Windows.Forms.Button();
            this.lblChooseTag = new System.Windows.Forms.Label();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddTag
            // 
            this.btnAddTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTag.Location = new System.Drawing.Point(12, 401);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(98, 35);
            this.btnAddTag.TabIndex = 16;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // lblChooseTag
            // 
            this.lblChooseTag.AutoSize = true;
            this.lblChooseTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseTag.Location = new System.Drawing.Point(12, 15);
            this.lblChooseTag.Name = "lblChooseTag";
            this.lblChooseTag.Size = new System.Drawing.Size(235, 24);
            this.lblChooseTag.TabIndex = 15;
            this.lblChooseTag.Text = "Please choose Tag to add:";
            // 
            // lbTags
            // 
            this.lbTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 24;
            this.lbTags.Location = new System.Drawing.Point(12, 67);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(330, 316);
            this.lbTags.TabIndex = 14;
            // 
            // ChooseFromExistingTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.lblChooseTag);
            this.Controls.Add(this.lbTags);
            this.Name = "ChooseFromExistingTags";
            this.Text = "ChooseFromExistingTags";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Label lblChooseTag;
        private System.Windows.Forms.ListBox lbTags;
    }
}