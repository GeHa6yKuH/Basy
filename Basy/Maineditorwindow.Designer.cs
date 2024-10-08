namespace Basy
{
    partial class Maineditorwindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TemplatesCredentialsPanel = new System.Windows.Forms.Panel();
            this.rbTemplates = new System.Windows.Forms.RadioButton();
            this.rbCredentials = new System.Windows.Forms.RadioButton();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.TemplatesCredentialsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 700);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(149, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1001, 79);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Controls.Add(this.TemplatesCredentialsPanel);
            this.panel4.Location = new System.Drawing.Point(149, -1);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1006, 79);
            this.panel4.TabIndex = 2;
            // 
            // TemplatesCredentialsPanel
            // 
            this.TemplatesCredentialsPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TemplatesCredentialsPanel.Controls.Add(this.rbTemplates);
            this.TemplatesCredentialsPanel.Controls.Add(this.rbCredentials);
            this.TemplatesCredentialsPanel.Location = new System.Drawing.Point(393, 13);
            this.TemplatesCredentialsPanel.Name = "TemplatesCredentialsPanel";
            this.TemplatesCredentialsPanel.Size = new System.Drawing.Size(234, 55);
            this.TemplatesCredentialsPanel.TabIndex = 2;
            // 
            // rbTemplates
            // 
            this.rbTemplates.AutoSize = true;
            this.rbTemplates.Location = new System.Drawing.Point(31, 21);
            this.rbTemplates.Name = "rbTemplates";
            this.rbTemplates.Size = new System.Drawing.Size(74, 17);
            this.rbTemplates.TabIndex = 0;
            this.rbTemplates.TabStop = true;
            this.rbTemplates.Text = "Templates";
            this.rbTemplates.UseVisualStyleBackColor = true;
            this.rbTemplates.CheckedChanged += new System.EventHandler(this.rbTemplates_CheckedChanged);
            // 
            // rbCredentials
            // 
            this.rbCredentials.AutoSize = true;
            this.rbCredentials.Location = new System.Drawing.Point(122, 21);
            this.rbCredentials.Name = "rbCredentials";
            this.rbCredentials.Size = new System.Drawing.Size(77, 17);
            this.rbCredentials.TabIndex = 1;
            this.rbCredentials.TabStop = true;
            this.rbCredentials.Text = "Credentials";
            this.rbCredentials.UseVisualStyleBackColor = true;
            this.rbCredentials.CheckedChanged += new System.EventHandler(this.rbCredentials_CheckedChanged);
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Location = new System.Drawing.Point(152, 81);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(1003, 618);
            this.mainContentPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Basy";
            // 
            // Maineditorwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 700);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Maineditorwindow";
            this.Text = "Maineditorwindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.TemplatesCredentialsPanel.ResumeLayout(false);
            this.TemplatesCredentialsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.Panel TemplatesCredentialsPanel;
        private System.Windows.Forms.RadioButton rbTemplates;
        private System.Windows.Forms.RadioButton rbCredentials;
        private System.Windows.Forms.Label label1;
    }
}