namespace Basy
{
    partial class VersionEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionEditor));
            this.lblText = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnParameters = new System.Windows.Forms.Button();
            this.mtbModify = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(23, 146);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(49, 23);
            this.lblText.TabIndex = 13;
            this.lblText.Text = "Text";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(23, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 23);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.Location = new System.Drawing.Point(23, 188);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(485, 141);
            this.tbText.TabIndex = 11;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(23, 93);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 27);
            this.tbName.TabIndex = 10;
            // 
            // btnParameters
            // 
            this.btnParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParameters.Location = new System.Drawing.Point(393, 146);
            this.btnParameters.Name = "btnParameters";
            this.btnParameters.Size = new System.Drawing.Size(115, 32);
            this.btnParameters.TabIndex = 15;
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
            this.mtbModify.Location = new System.Drawing.Point(27, 366);
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
            // VersionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 423);
            this.Controls.Add(this.mtbModify);
            this.Controls.Add(this.btnParameters);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VersionEditor";
            this.Text = "Version Editor";
            this.Load += new System.EventHandler(this.VersionEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnParameters;
        private MaterialSkin.Controls.MaterialButton mtbModify;
    }
}