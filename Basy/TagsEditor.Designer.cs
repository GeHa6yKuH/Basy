namespace Basy
{
    partial class TagsEditor
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
            this.btnAddExistingTag = new System.Windows.Forms.Button();
            this.lblTags = new System.Windows.Forms.Label();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.btnAddNewTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddExistingTag
            // 
            this.btnAddExistingTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddExistingTag.Location = new System.Drawing.Point(12, 403);
            this.btnAddExistingTag.Name = "btnAddExistingTag";
            this.btnAddExistingTag.Size = new System.Drawing.Size(144, 35);
            this.btnAddExistingTag.TabIndex = 13;
            this.btnAddExistingTag.Text = "Add Existing Tag";
            this.btnAddExistingTag.UseVisualStyleBackColor = true;
            this.btnAddExistingTag.Click += new System.EventHandler(this.btnAddExistingTag_Click);
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTags.Location = new System.Drawing.Point(12, 17);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(52, 24);
            this.lblTags.TabIndex = 12;
            this.lblTags.Text = "Tags";
            // 
            // lbTags
            // 
            this.lbTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 24;
            this.lbTags.Location = new System.Drawing.Point(12, 61);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(330, 316);
            this.lbTags.TabIndex = 11;
            // 
            // btnAddNewTag
            // 
            this.btnAddNewTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewTag.Location = new System.Drawing.Point(174, 403);
            this.btnAddNewTag.Name = "btnAddNewTag";
            this.btnAddNewTag.Size = new System.Drawing.Size(127, 35);
            this.btnAddNewTag.TabIndex = 14;
            this.btnAddNewTag.Text = "Add New Tag";
            this.btnAddNewTag.UseVisualStyleBackColor = true;
            this.btnAddNewTag.Click += new System.EventHandler(this.btnAddNewTag_Click);
            // 
            // TagsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.btnAddNewTag);
            this.Controls.Add(this.btnAddExistingTag);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.lbTags);
            this.Name = "TagsEditor";
            this.Text = "TagsEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddExistingTag;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.ListBox lbTags;
        private System.Windows.Forms.Button btnAddNewTag;
    }
}