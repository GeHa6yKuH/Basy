namespace Basy
{
    partial class ClipBoardPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipBoardPopup));
            this.lbClips = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbClips
            // 
            this.lbClips.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbClips.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClips.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbClips.FormattingEnabled = true;
            this.lbClips.ItemHeight = 23;
            this.lbClips.Location = new System.Drawing.Point(0, 0);
            this.lbClips.Name = "lbClips";
            this.lbClips.Size = new System.Drawing.Size(310, 326);
            this.lbClips.TabIndex = 1;
            // 
            // ClipBoardPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(310, 326);
            this.Controls.Add(this.lbClips);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClipBoardPopup";
            this.Text = "ClipBoardPopup";
            this.Load += new System.EventHandler(this.ClipBoardPopup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbClips;
    }
}