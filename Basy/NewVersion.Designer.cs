namespace Basy
{
    partial class NewVersion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewVersion));
            this.lblText = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.mtbAddtag = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(21, 149);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(47, 24);
            this.lblText.TabIndex = 8;
            this.lblText.Text = "Text";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(21, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 23);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.Location = new System.Drawing.Point(21, 191);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(485, 141);
            this.tbText.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(21, 96);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 26);
            this.tbName.TabIndex = 5;
            // 
            // mtbAddtag
            // 
            this.mtbAddtag.AutoSize = false;
            this.mtbAddtag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbAddtag.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbAddtag.Depth = 0;
            this.mtbAddtag.HighEmphasis = true;
            this.mtbAddtag.Icon = null;
            this.mtbAddtag.Location = new System.Drawing.Point(21, 382);
            this.mtbAddtag.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbAddtag.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbAddtag.Name = "mtbAddtag";
            this.mtbAddtag.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbAddtag.Size = new System.Drawing.Size(83, 34);
            this.mtbAddtag.TabIndex = 18;
            this.mtbAddtag.Text = "Add";
            this.mtbAddtag.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbAddtag.UseAccentColor = false;
            this.mtbAddtag.UseVisualStyleBackColor = true;
            this.mtbAddtag.Click += new System.EventHandler(this.mtbAddtag_Click);
            // 
            // NewVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.mtbAddtag);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewVersion";
            this.Text = "New Version";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbName;
        private MaterialSkin.Controls.MaterialButton mtbAddtag;
    }
}