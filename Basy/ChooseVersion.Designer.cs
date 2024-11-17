namespace Basy
{
    partial class ChooseVersion
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
            this.lblPleaseChoose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPleaseChoose
            // 
            this.lblPleaseChoose.AutoSize = true;
            this.lblPleaseChoose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPleaseChoose.Location = new System.Drawing.Point(111, 27);
            this.lblPleaseChoose.Name = "lblPleaseChoose";
            this.lblPleaseChoose.Size = new System.Drawing.Size(251, 25);
            this.lblPleaseChoose.TabIndex = 0;
            this.lblPleaseChoose.Text = "Please Choose Version";
            // 
            // ChooseVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 196);
            this.Controls.Add(this.lblPleaseChoose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseVersion";
            this.Text = "ChooseVersion";
            this.Load += new System.EventHandler(this.ChooseVersion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPleaseChoose;
    }
}