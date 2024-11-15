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
            this.pnlColorPreview = new System.Windows.Forms.Panel();
            this.btnPickAColor = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEditTag = new System.Windows.Forms.Label();
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
            this.btnPickAColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPickAColor.Location = new System.Drawing.Point(100, 128);
            this.btnPickAColor.Name = "btnPickAColor";
            this.btnPickAColor.Size = new System.Drawing.Size(123, 31);
            this.btnPickAColor.TabIndex = 25;
            this.btnPickAColor.Text = "Pick a Color";
            this.btnPickAColor.UseVisualStyleBackColor = true;
            this.btnPickAColor.Click += new System.EventHandler(this.btnPickAColor_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModify.Location = new System.Drawing.Point(13, 185);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(99, 26);
            this.btnModify.TabIndex = 24;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColor.Location = new System.Drawing.Point(13, 130);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(55, 24);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // lblEditTag
            // 
            this.lblEditTag.AutoSize = true;
            this.lblEditTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEditTag.Location = new System.Drawing.Point(13, 21);
            this.lblEditTag.Name = "lblEditTag";
            this.lblEditTag.Size = new System.Drawing.Size(76, 20);
            this.lblEditTag.TabIndex = 20;
            this.lblEditTag.Text = "Edit Tag";
            // 
            // TagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 226);
            this.Controls.Add(this.pnlColorPreview);
            this.Controls.Add(this.btnPickAColor);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEditTag);
            this.Name = "TagEditor";
            this.Text = "TagEditor";
            this.Load += new System.EventHandler(this.TagEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlColorPreview;
        private System.Windows.Forms.Button btnPickAColor;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEditTag;
    }
}