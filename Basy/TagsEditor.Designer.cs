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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagsEditor));
            this.lblTags = new System.Windows.Forms.Label();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.mtbAddNewTag = new MaterialSkin.Controls.MaterialButton();
            this.mtbAddExistingTag = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTags.Location = new System.Drawing.Point(12, 17);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(53, 23);
            this.lblTags.TabIndex = 12;
            this.lblTags.Text = "Tags";
            // 
            // lbTags
            // 
            this.lbTags.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 23;
            this.lbTags.Location = new System.Drawing.Point(12, 61);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(330, 326);
            this.lbTags.TabIndex = 11;
            // 
            // mtbAddNewTag
            // 
            this.mtbAddNewTag.AutoSize = false;
            this.mtbAddNewTag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbAddNewTag.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbAddNewTag.Depth = 0;
            this.mtbAddNewTag.HighEmphasis = true;
            this.mtbAddNewTag.Icon = null;
            this.mtbAddNewTag.Location = new System.Drawing.Point(187, 401);
            this.mtbAddNewTag.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbAddNewTag.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbAddNewTag.Name = "mtbAddNewTag";
            this.mtbAddNewTag.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbAddNewTag.Size = new System.Drawing.Size(130, 34);
            this.mtbAddNewTag.TabIndex = 18;
            this.mtbAddNewTag.Text = "Add New Tag";
            this.mtbAddNewTag.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbAddNewTag.UseAccentColor = false;
            this.mtbAddNewTag.UseVisualStyleBackColor = true;
            this.mtbAddNewTag.Click += new System.EventHandler(this.mtbAddNewTag_Click);
            // 
            // mtbAddExistingTag
            // 
            this.mtbAddExistingTag.AutoSize = false;
            this.mtbAddExistingTag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbAddExistingTag.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbAddExistingTag.Depth = 0;
            this.mtbAddExistingTag.HighEmphasis = true;
            this.mtbAddExistingTag.Icon = null;
            this.mtbAddExistingTag.Location = new System.Drawing.Point(12, 401);
            this.mtbAddExistingTag.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbAddExistingTag.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbAddExistingTag.Name = "mtbAddExistingTag";
            this.mtbAddExistingTag.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbAddExistingTag.Size = new System.Drawing.Size(148, 34);
            this.mtbAddExistingTag.TabIndex = 19;
            this.mtbAddExistingTag.Text = "Add Existing Tag";
            this.mtbAddExistingTag.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbAddExistingTag.UseAccentColor = false;
            this.mtbAddExistingTag.UseVisualStyleBackColor = true;
            this.mtbAddExistingTag.Click += new System.EventHandler(this.mtbAddExistingTag_Click);
            // 
            // TagsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.mtbAddExistingTag);
            this.Controls.Add(this.mtbAddNewTag);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.lbTags);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TagsEditor";
            this.Text = "Tags Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.ListBox lbTags;
        private MaterialSkin.Controls.MaterialButton mtbAddNewTag;
        private MaterialSkin.Controls.MaterialButton mtbAddExistingTag;
    }
}