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
            this.btnModify = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnEditVersions = new System.Windows.Forms.Button();
            this.btnTags = new System.Windows.Forms.Button();
            this.btnParameters = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModify.Location = new System.Drawing.Point(32, 433);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(104, 32);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(28, 152);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(47, 24);
            this.lblText.TabIndex = 8;
            this.lblText.Text = "Text";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(28, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(28, 194);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(419, 141);
            this.tbText.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(28, 99);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 26);
            this.tbName.TabIndex = 5;
            // 
            // btnEditVersions
            // 
            this.btnEditVersions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditVersions.Location = new System.Drawing.Point(343, 351);
            this.btnEditVersions.Name = "btnEditVersions";
            this.btnEditVersions.Size = new System.Drawing.Size(104, 32);
            this.btnEditVersions.TabIndex = 10;
            this.btnEditVersions.Text = "Versions";
            this.btnEditVersions.UseVisualStyleBackColor = true;
            this.btnEditVersions.Click += new System.EventHandler(this.btnEditVersions_Click);
            // 
            // btnTags
            // 
            this.btnTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTags.Location = new System.Drawing.Point(193, 351);
            this.btnTags.Name = "btnTags";
            this.btnTags.Size = new System.Drawing.Size(104, 32);
            this.btnTags.TabIndex = 11;
            this.btnTags.Text = "Tags";
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // btnParameters
            // 
            this.btnParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParameters.Location = new System.Drawing.Point(28, 351);
            this.btnParameters.Name = "btnParameters";
            this.btnParameters.Size = new System.Drawing.Size(115, 32);
            this.btnParameters.TabIndex = 12;
            this.btnParameters.Text = "Parameters";
            this.btnParameters.UseVisualStyleBackColor = true;
            this.btnParameters.Click += new System.EventHandler(this.btnParameters_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(343, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 32);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TemplateEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 477);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnParameters);
            this.Controls.Add(this.btnTags);
            this.Controls.Add(this.btnEditVersions);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbName);
            this.Name = "TemplateEditor";
            this.Text = "TemplateEditor";
            this.Load += new System.EventHandler(this.TemplateEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnEditVersions;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Button btnParameters;
        private System.Windows.Forms.Button btnDelete;
    }
}