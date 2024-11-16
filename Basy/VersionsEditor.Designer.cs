namespace Basy
{
    partial class VersionsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionsEditor));
            this.lbVersions = new System.Windows.Forms.ListBox();
            this.lblVersions = new System.Windows.Forms.Label();
            this.mtbAdd = new MaterialSkin.Controls.MaterialButton();
            this.mtbDelete = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbVersions
            // 
            this.lbVersions.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVersions.FormattingEnabled = true;
            this.lbVersions.ItemHeight = 23;
            this.lbVersions.Location = new System.Drawing.Point(12, 66);
            this.lbVersions.Name = "lbVersions";
            this.lbVersions.Size = new System.Drawing.Size(330, 303);
            this.lbVersions.TabIndex = 0;
            // 
            // lblVersions
            // 
            this.lblVersions.AutoSize = true;
            this.lblVersions.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVersions.Location = new System.Drawing.Point(12, 22);
            this.lblVersions.Name = "lblVersions";
            this.lblVersions.Size = new System.Drawing.Size(91, 23);
            this.lblVersions.TabIndex = 8;
            this.lblVersions.Text = "Versions";
            // 
            // mtbAdd
            // 
            this.mtbAdd.AutoSize = false;
            this.mtbAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbAdd.Depth = 0;
            this.mtbAdd.HighEmphasis = true;
            this.mtbAdd.Icon = null;
            this.mtbAdd.Location = new System.Drawing.Point(16, 392);
            this.mtbAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbAdd.Name = "mtbAdd";
            this.mtbAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbAdd.Size = new System.Drawing.Size(49, 31);
            this.mtbAdd.TabIndex = 18;
            this.mtbAdd.Text = "+";
            this.mtbAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbAdd.UseAccentColor = false;
            this.mtbAdd.UseVisualStyleBackColor = true;
            this.mtbAdd.Click += new System.EventHandler(this.mtbAdd_Click);
            // 
            // mtbDelete
            // 
            this.mtbDelete.AutoSize = false;
            this.mtbDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbDelete.Depth = 0;
            this.mtbDelete.HighEmphasis = true;
            this.mtbDelete.Icon = null;
            this.mtbDelete.Location = new System.Drawing.Point(82, 392);
            this.mtbDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbDelete.Name = "mtbDelete";
            this.mtbDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbDelete.Size = new System.Drawing.Size(95, 31);
            this.mtbDelete.TabIndex = 19;
            this.mtbDelete.Text = "Delete";
            this.mtbDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbDelete.UseAccentColor = false;
            this.mtbDelete.UseVisualStyleBackColor = true;
            this.mtbDelete.Click += new System.EventHandler(this.mtbDelete_Click);
            // 
            // VersionsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 443);
            this.Controls.Add(this.mtbDelete);
            this.Controls.Add(this.mtbAdd);
            this.Controls.Add(this.lblVersions);
            this.Controls.Add(this.lbVersions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VersionsEditor";
            this.Text = "Versions Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVersions;
        private System.Windows.Forms.Label lblVersions;
        private MaterialSkin.Controls.MaterialButton mtbAdd;
        private MaterialSkin.Controls.MaterialButton mtbDelete;
    }
}