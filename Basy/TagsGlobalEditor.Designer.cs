namespace Basy
{
    partial class TagsGlobalEditor
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
            this.btnAddNewTag = new System.Windows.Forms.Button();
            this.lblAllTags = new System.Windows.Forms.Label();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewTag
            // 
            this.btnAddNewTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewTag.Location = new System.Drawing.Point(12, 394);
            this.btnAddNewTag.Name = "btnAddNewTag";
            this.btnAddNewTag.Size = new System.Drawing.Size(127, 35);
            this.btnAddNewTag.TabIndex = 18;
            this.btnAddNewTag.Text = "Add New Tag";
            this.btnAddNewTag.UseVisualStyleBackColor = true;
            this.btnAddNewTag.Click += new System.EventHandler(this.btnAddNewTag_Click);
            // 
            // lblAllTags
            // 
            this.lblAllTags.AutoSize = true;
            this.lblAllTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllTags.Location = new System.Drawing.Point(12, 15);
            this.lblAllTags.Name = "lblAllTags";
            this.lblAllTags.Size = new System.Drawing.Size(78, 24);
            this.lblAllTags.TabIndex = 16;
            this.lblAllTags.Text = "All Tags";
            // 
            // lbTags
            // 
            this.lbTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 24;
            this.lbTags.Location = new System.Drawing.Point(12, 59);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(330, 316);
            this.lbTags.TabIndex = 15;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSelected.Location = new System.Drawing.Point(160, 394);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(168, 35);
            this.btnDeleteSelected.TabIndex = 19;
            this.btnDeleteSelected.Text = "Delete Selected Tag";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // TagsGlobalEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnAddNewTag);
            this.Controls.Add(this.lblAllTags);
            this.Controls.Add(this.lbTags);
            this.Name = "TagsGlobalEditor";
            this.Text = "TagsGlobalEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewTag;
        private System.Windows.Forms.Label lblAllTags;
        private System.Windows.Forms.ListBox lbTags;
        private System.Windows.Forms.Button btnDeleteSelected;
    }
}