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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFromExistingTags));
            this.lblChooseTag = new System.Windows.Forms.Label();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.mtbAddtag = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblChooseTag
            // 
            this.lblChooseTag.AutoSize = true;
            this.lblChooseTag.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseTag.Location = new System.Drawing.Point(12, 15);
            this.lblChooseTag.Name = "lblChooseTag";
            this.lblChooseTag.Size = new System.Drawing.Size(261, 23);
            this.lblChooseTag.TabIndex = 15;
            this.lblChooseTag.Text = "Please choose Tag to add:";
            // 
            // lbTags
            // 
            this.lbTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 24;
            this.lbTags.Location = new System.Drawing.Point(16, 62);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(330, 316);
            this.lbTags.TabIndex = 14;
            // 
            // mtbAddtag
            // 
            this.mtbAddtag.AutoSize = false;
            this.mtbAddtag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbAddtag.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbAddtag.Depth = 0;
            this.mtbAddtag.HighEmphasis = true;
            this.mtbAddtag.Icon = null;
            this.mtbAddtag.Location = new System.Drawing.Point(16, 401);
            this.mtbAddtag.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbAddtag.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbAddtag.Name = "mtbAddtag";
            this.mtbAddtag.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbAddtag.Size = new System.Drawing.Size(111, 34);
            this.mtbAddtag.TabIndex = 17;
            this.mtbAddtag.Text = "Add Tag";
            this.mtbAddtag.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbAddtag.UseAccentColor = false;
            this.mtbAddtag.UseVisualStyleBackColor = true;
            this.mtbAddtag.Click += new System.EventHandler(this.mtbAddtag_Click);
            // 
            // ChooseFromExistingTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.mtbAddtag);
            this.Controls.Add(this.lblChooseTag);
            this.Controls.Add(this.lbTags);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseFromExistingTags";
            this.Text = "Choose Tags";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChooseTag;
        private System.Windows.Forms.ListBox lbTags;
        private MaterialSkin.Controls.MaterialButton mtbAddtag;
    }
}