namespace Basy
{
    partial class ParametersTemplateWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametersTemplateWindow));
            this.mtbCopy = new MaterialSkin.Controls.MaterialButton();
            this.pnlTemplate = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mtbCopy
            // 
            this.mtbCopy.AutoSize = false;
            this.mtbCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbCopy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbCopy.Depth = 0;
            this.mtbCopy.HighEmphasis = true;
            this.mtbCopy.Icon = null;
            this.mtbCopy.Location = new System.Drawing.Point(13, 330);
            this.mtbCopy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbCopy.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbCopy.Name = "mtbCopy";
            this.mtbCopy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbCopy.Size = new System.Drawing.Size(112, 36);
            this.mtbCopy.TabIndex = 11;
            this.mtbCopy.Text = "Copy";
            this.mtbCopy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbCopy.UseAccentColor = false;
            this.mtbCopy.UseVisualStyleBackColor = true;
            this.mtbCopy.Click += new System.EventHandler(this.mtbCopy_Click);
            // 
            // pnlTemplate
            // 
            this.pnlTemplate.Location = new System.Drawing.Point(13, 12);
            this.pnlTemplate.Name = "pnlTemplate";
            this.pnlTemplate.Size = new System.Drawing.Size(661, 309);
            this.pnlTemplate.TabIndex = 0;
            // 
            // ParametersTemplateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 381);
            this.Controls.Add(this.pnlTemplate);
            this.Controls.Add(this.mtbCopy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParametersTemplateWindow";
            this.Text = "ParametersTemplateWindow";
            this.Load += new System.EventHandler(this.ParametersTemplateWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton mtbCopy;
        private System.Windows.Forms.Panel pnlTemplate;
    }
}