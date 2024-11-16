namespace Basy
{
    partial class TemplateEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateEditor));
            this.lblText = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnEditVersions = new System.Windows.Forms.Button();
            this.btnTags = new System.Windows.Forms.Button();
            this.btnParameters = new System.Windows.Forms.Button();
            this.mtbModify = new MaterialSkin.Controls.MaterialButton();
            this.mtbDelete = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(8, 132);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(49, 23);
            this.lblText.TabIndex = 8;
            this.lblText.Text = "Text";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(12, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 23);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.Location = new System.Drawing.Point(12, 174);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(419, 141);
            this.tbText.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(12, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 27);
            this.tbName.TabIndex = 5;
            // 
            // btnEditVersions
            // 
            this.btnEditVersions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditVersions.Location = new System.Drawing.Point(437, 269);
            this.btnEditVersions.Name = "btnEditVersions";
            this.btnEditVersions.Size = new System.Drawing.Size(115, 32);
            this.btnEditVersions.TabIndex = 10;
            this.btnEditVersions.Text = "Versions";
            this.btnEditVersions.UseVisualStyleBackColor = true;
            this.btnEditVersions.Click += new System.EventHandler(this.btnEditVersions_Click);
            // 
            // btnTags
            // 
            this.btnTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTags.Location = new System.Drawing.Point(437, 222);
            this.btnTags.Name = "btnTags";
            this.btnTags.Size = new System.Drawing.Size(115, 32);
            this.btnTags.TabIndex = 11;
            this.btnTags.Text = "Tags";
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // btnParameters
            // 
            this.btnParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParameters.Location = new System.Drawing.Point(437, 174);
            this.btnParameters.Name = "btnParameters";
            this.btnParameters.Size = new System.Drawing.Size(115, 32);
            this.btnParameters.TabIndex = 12;
            this.btnParameters.Text = "Parameters";
            this.btnParameters.UseVisualStyleBackColor = true;
            this.btnParameters.Click += new System.EventHandler(this.btnParameters_Click);
            // 
            // mtbModify
            // 
            this.mtbModify.AutoSize = false;
            this.mtbModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbModify.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbModify.Depth = 0;
            this.mtbModify.HighEmphasis = true;
            this.mtbModify.Icon = null;
            this.mtbModify.Location = new System.Drawing.Point(12, 347);
            this.mtbModify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbModify.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbModify.Name = "mtbModify";
            this.mtbModify.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbModify.Size = new System.Drawing.Size(111, 34);
            this.mtbModify.TabIndex = 18;
            this.mtbModify.Text = "Modify";
            this.mtbModify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbModify.UseAccentColor = false;
            this.mtbModify.UseVisualStyleBackColor = true;
            this.mtbModify.Click += new System.EventHandler(this.mtbModify_Click);
            // 
            // mtbDelete
            // 
            this.mtbDelete.AutoSize = false;
            this.mtbDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbDelete.Depth = 0;
            this.mtbDelete.HighEmphasis = true;
            this.mtbDelete.Icon = null;
            this.mtbDelete.Location = new System.Drawing.Point(146, 347);
            this.mtbDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbDelete.Name = "mtbDelete";
            this.mtbDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbDelete.Size = new System.Drawing.Size(111, 34);
            this.mtbDelete.TabIndex = 19;
            this.mtbDelete.Text = "Delete";
            this.mtbDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbDelete.UseAccentColor = false;
            this.mtbDelete.UseVisualStyleBackColor = true;
            this.mtbDelete.Click += new System.EventHandler(this.mtbDelete_Click);
            // 
            // TemplateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 414);
            this.Controls.Add(this.mtbDelete);
            this.Controls.Add(this.mtbModify);
            this.Controls.Add(this.btnParameters);
            this.Controls.Add(this.btnTags);
            this.Controls.Add(this.btnEditVersions);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TemplateEditor";
            this.Text = "Template Editor";
            this.Load += new System.EventHandler(this.TemplateEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnEditVersions;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Button btnParameters;
        private MaterialSkin.Controls.MaterialButton mtbModify;
        private MaterialSkin.Controls.MaterialButton mtbDelete;
    }
}