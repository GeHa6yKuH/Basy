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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagsGlobalEditor));
            this.lblAllTags = new System.Windows.Forms.Label();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.mtbAddNewTag = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblAllTags
            // 
            this.lblAllTags.AutoSize = true;
            this.lblAllTags.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllTags.Location = new System.Drawing.Point(12, 15);
            this.lblAllTags.Name = "lblAllTags";
            this.lblAllTags.Size = new System.Drawing.Size(85, 23);
            this.lblAllTags.TabIndex = 16;
            this.lblAllTags.Text = "All Tags";
            // 
            // lbTags
            // 
            this.lbTags.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 23;
            this.lbTags.Location = new System.Drawing.Point(12, 59);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(330, 303);
            this.lbTags.TabIndex = 15;
            // 
            // mtbAddNewTag
            // 
            this.mtbAddNewTag.AutoSize = false;
            this.mtbAddNewTag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbAddNewTag.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbAddNewTag.Depth = 0;
            this.mtbAddNewTag.HighEmphasis = true;
            this.mtbAddNewTag.Icon = null;
            this.mtbAddNewTag.Location = new System.Drawing.Point(12, 394);
            this.mtbAddNewTag.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbAddNewTag.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbAddNewTag.Name = "mtbAddNewTag";
            this.mtbAddNewTag.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbAddNewTag.Size = new System.Drawing.Size(121, 34);
            this.mtbAddNewTag.TabIndex = 20;
            this.mtbAddNewTag.Text = "Add New Tag";
            this.mtbAddNewTag.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbAddNewTag.UseAccentColor = false;
            this.mtbAddNewTag.UseVisualStyleBackColor = true;
            this.mtbAddNewTag.Click += new System.EventHandler(this.mtbAddNewTag_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(157, 394);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(168, 34);
            this.materialButton1.TabIndex = 21;
            this.materialButton1.Text = "Delete Selected Tag";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // TagsGlobalEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.mtbAddNewTag);
            this.Controls.Add(this.lblAllTags);
            this.Controls.Add(this.lbTags);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TagsGlobalEditor";
            this.Text = "Tags Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAllTags;
        private System.Windows.Forms.ListBox lbTags;
        private MaterialSkin.Controls.MaterialButton mtbAddNewTag;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}