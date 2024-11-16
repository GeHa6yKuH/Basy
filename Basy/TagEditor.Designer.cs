namespace Basy
{
    partial class TagEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagEditor));
            this.pnlColorPreview = new System.Windows.Forms.Panel();
            this.btnPickAColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEditTag = new System.Windows.Forms.Label();
            this.mtbModify = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // pnlColorPreview
            // 
            this.pnlColorPreview.Location = new System.Drawing.Point(244, 128);
            this.pnlColorPreview.Name = "pnlColorPreview";
            this.pnlColorPreview.Size = new System.Drawing.Size(35, 31);
            this.pnlColorPreview.TabIndex = 26;
            // 
            // btnPickAColor
            // 
            this.btnPickAColor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPickAColor.Location = new System.Drawing.Point(100, 128);
            this.btnPickAColor.Name = "btnPickAColor";
            this.btnPickAColor.Size = new System.Drawing.Size(123, 31);
            this.btnPickAColor.TabIndex = 25;
            this.btnPickAColor.Text = "Pick a Color";
            this.btnPickAColor.UseVisualStyleBackColor = true;
            this.btnPickAColor.Click += new System.EventHandler(this.btnPickAColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColor.Location = new System.Drawing.Point(13, 130);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(61, 23);
            this.lblColor.TabIndex = 23;
            this.lblColor.Text = "Color";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(100, 70);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 26);
            this.tbName.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // lblEditTag
            // 
            this.lblEditTag.AutoSize = true;
            this.lblEditTag.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEditTag.Location = new System.Drawing.Point(13, 21);
            this.lblEditTag.Name = "lblEditTag";
            this.lblEditTag.Size = new System.Drawing.Size(87, 23);
            this.lblEditTag.TabIndex = 20;
            this.lblEditTag.Text = "Edit Tag";
            // 
            // mtbModify
            // 
            this.mtbModify.AutoSize = false;
            this.mtbModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbModify.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbModify.Depth = 0;
            this.mtbModify.HighEmphasis = true;
            this.mtbModify.Icon = null;
            this.mtbModify.Location = new System.Drawing.Point(13, 185);
            this.mtbModify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbModify.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbModify.Name = "mtbModify";
            this.mtbModify.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbModify.Size = new System.Drawing.Size(108, 34);
            this.mtbModify.TabIndex = 27;
            this.mtbModify.Text = "Modify";
            this.mtbModify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbModify.UseAccentColor = false;
            this.mtbModify.UseVisualStyleBackColor = true;
            this.mtbModify.Click += new System.EventHandler(this.mtbModify_Click);
            // 
            // TagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 234);
            this.Controls.Add(this.mtbModify);
            this.Controls.Add(this.pnlColorPreview);
            this.Controls.Add(this.btnPickAColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEditTag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TagEditor";
            this.Text = "Tag Editor";
            this.Load += new System.EventHandler(this.TagEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlColorPreview;
        private System.Windows.Forms.Button btnPickAColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEditTag;
        private MaterialSkin.Controls.MaterialButton mtbModify;
    }
}