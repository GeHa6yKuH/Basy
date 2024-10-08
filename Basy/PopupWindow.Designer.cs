namespace Basy
{
    partial class PopupWindow
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
            this.lbTemplates = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbTemplates
            // 
            this.lbTemplates.BackColor = System.Drawing.Color.DarkBlue;
            this.lbTemplates.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTemplates.ForeColor = System.Drawing.SystemColors.Info;
            this.lbTemplates.FormattingEnabled = true;
            this.lbTemplates.ItemHeight = 18;
            this.lbTemplates.Location = new System.Drawing.Point(1, 0);
            this.lbTemplates.Name = "lbTemplates";
            this.lbTemplates.Size = new System.Drawing.Size(308, 454);
            this.lbTemplates.TabIndex = 0;
            this.lbTemplates.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PopupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.lbTemplates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupWindow";
            this.Text = "PopupWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTemplates;
    }
}