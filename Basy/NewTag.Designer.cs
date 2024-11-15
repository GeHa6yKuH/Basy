namespace Basy
{
    partial class NewTag
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
            this.lblNewTag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnAddNewTag = new System.Windows.Forms.Button();
            this.btnPickAColor = new System.Windows.Forms.Button();
            this.pnlColorPreview = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblNewTag
            // 
            this.lblNewTag.AutoSize = true;
            this.lblNewTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewTag.Location = new System.Drawing.Point(12, 24);
            this.lblNewTag.Name = "lblNewTag";
            this.lblNewTag.Size = new System.Drawing.Size(83, 20);
            this.lblNewTag.TabIndex = 0;
            this.lblNewTag.Text = "New Tag:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(99, 73);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 26);
            this.tbName.TabIndex = 15;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColor.Location = new System.Drawing.Point(12, 133);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(55, 24);
            this.lblColor.TabIndex = 16;
            this.lblColor.Text = "Color";
            // 
            // btnAddNewTag
            // 
            this.btnAddNewTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewTag.Location = new System.Drawing.Point(12, 188);
            this.btnAddNewTag.Name = "btnAddNewTag";
            this.btnAddNewTag.Size = new System.Drawing.Size(103, 26);
            this.btnAddNewTag.TabIndex = 17;
            this.btnAddNewTag.Text = "Add New Tag";
            this.btnAddNewTag.UseVisualStyleBackColor = true;
            this.btnAddNewTag.Click += new System.EventHandler(this.btnAddNewTag_Click);
            // 
            // btnPickAColor
            // 
            this.btnPickAColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPickAColor.Location = new System.Drawing.Point(99, 131);
            this.btnPickAColor.Name = "btnPickAColor";
            this.btnPickAColor.Size = new System.Drawing.Size(123, 31);
            this.btnPickAColor.TabIndex = 18;
            this.btnPickAColor.Text = "Pick a Color";
            this.btnPickAColor.UseVisualStyleBackColor = true;
            this.btnPickAColor.Click += new System.EventHandler(this.btnPickAColor_Click);
            // 
            // pnlColorPreview
            // 
            this.pnlColorPreview.Location = new System.Drawing.Point(243, 131);
            this.pnlColorPreview.Name = "pnlColorPreview";
            this.pnlColorPreview.Size = new System.Drawing.Size(35, 31);
            this.pnlColorPreview.TabIndex = 19;
            // 
            // NewTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 226);
            this.Controls.Add(this.pnlColorPreview);
            this.Controls.Add(this.btnPickAColor);
            this.Controls.Add(this.btnAddNewTag);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNewTag);
            this.Name = "NewTag";
            this.Text = "NewTag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnAddNewTag;
        private System.Windows.Forms.Button btnPickAColor;
        private System.Windows.Forms.Panel pnlColorPreview;
    }
}