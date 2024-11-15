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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maineditorwindow));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.ibHowTo = new FontAwesome.Sharp.IconButton();
            this.ibHistory = new FontAwesome.Sharp.IconButton();
            this.ibSettings = new FontAwesome.Sharp.IconButton();
            this.ibTemplates = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentControl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibShare = new FontAwesome.Sharp.IconButton();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.pnlLeft.Controls.Add(this.ibHowTo);
            this.pnlLeft.Controls.Add(this.ibHistory);
            this.pnlLeft.Controls.Add(this.ibSettings);
            this.pnlLeft.Controls.Add(this.ibTemplates);
            this.pnlLeft.Controls.Add(this.pnlLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(183, 634);
            this.pnlLeft.TabIndex = 1;
            // 
            // ibHowTo
            // 
            this.ibHowTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibHowTo.FlatAppearance.BorderSize = 0;
            this.ibHowTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibHowTo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibHowTo.ForeColor = System.Drawing.Color.Cornsilk;
            this.ibHowTo.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.ibHowTo.IconColor = System.Drawing.Color.Cornsilk;
            this.ibHowTo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibHowTo.IconSize = 35;
            this.ibHowTo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibHowTo.Location = new System.Drawing.Point(0, 301);
            this.ibHowTo.Name = "ibHowTo";
            this.ibHowTo.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.ibHowTo.Size = new System.Drawing.Size(183, 66);
            this.ibHowTo.TabIndex = 12;
            this.ibHowTo.Text = "How-To";
            this.ibHowTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibHowTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibHowTo.UseVisualStyleBackColor = true;
            this.ibHowTo.Click += new System.EventHandler(this.ibHowTo_Click);
            // 
            // ibHistory
            // 
            this.ibHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibHistory.FlatAppearance.BorderSize = 0;
            this.ibHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibHistory.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibHistory.ForeColor = System.Drawing.Color.Cornsilk;
            this.ibHistory.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.ibHistory.IconColor = System.Drawing.Color.Cornsilk;
            this.ibHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibHistory.IconSize = 35;
            this.ibHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibHistory.Location = new System.Drawing.Point(0, 235);
            this.ibHistory.Name = "ibHistory";
            this.ibHistory.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.ibHistory.Size = new System.Drawing.Size(183, 66);
            this.ibHistory.TabIndex = 11;
            this.ibHistory.Text = "History";
            this.ibHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibHistory.UseVisualStyleBackColor = true;
            this.ibHistory.Click += new System.EventHandler(this.ibHowTo_Click);
            // 
            // ibSettings
            // 
            this.ibSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibSettings.FlatAppearance.BorderSize = 0;
            this.ibSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSettings.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibSettings.ForeColor = System.Drawing.Color.Cornsilk;
            this.ibSettings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.ibSettings.IconColor = System.Drawing.Color.Cornsilk;
            this.ibSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSettings.IconSize = 35;
            this.ibSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSettings.Location = new System.Drawing.Point(0, 169);
            this.ibSettings.Name = "ibSettings";
            this.ibSettings.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.ibSettings.Size = new System.Drawing.Size(183, 66);
            this.ibSettings.TabIndex = 10;
            this.ibSettings.Text = "Settings";
            this.ibSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibSettings.UseVisualStyleBackColor = true;
            this.ibSettings.Click += new System.EventHandler(this.ibHowTo_Click);
            // 
            // ibTemplates
            // 
            this.ibTemplates.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibTemplates.FlatAppearance.BorderSize = 0;
            this.ibTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibTemplates.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibTemplates.ForeColor = System.Drawing.Color.Cornsilk;
            this.ibTemplates.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.ibTemplates.IconColor = System.Drawing.Color.Cornsilk;
            this.ibTemplates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibTemplates.IconSize = 35;
            this.ibTemplates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibTemplates.Location = new System.Drawing.Point(0, 103);
            this.ibTemplates.Name = "ibTemplates";
            this.ibTemplates.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.ibTemplates.Size = new System.Drawing.Size(183, 66);
            this.ibTemplates.TabIndex = 9;
            this.ibTemplates.Text = "Templates";
            this.ibTemplates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibTemplates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibTemplates.UseVisualStyleBackColor = true;
            this.ibTemplates.Click += new System.EventHandler(this.ibHowTo_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(183, 103);
            this.pnlLogo.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 57);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentControl
            // 
            this.lblCurrentControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentControl.AutoSize = true;
            this.lblCurrentControl.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentControl.ForeColor = System.Drawing.Color.LightBlue;
            this.lblCurrentControl.Location = new System.Drawing.Point(669, 28);
            this.lblCurrentControl.Name = "lblCurrentControl";
            this.lblCurrentControl.Size = new System.Drawing.Size(134, 25);
            this.lblCurrentControl.TabIndex = 5;
            this.lblCurrentControl.Text = "Templates";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.ibShare);
            this.panel1.Controls.Add(this.lblCurrentControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(183, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 80);
            this.panel1.TabIndex = 4;
            // 
            // ibShare
            // 
            this.ibShare.FlatAppearance.BorderSize = 0;
            this.ibShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibShare.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ibShare.ForeColor = System.Drawing.Color.Cornsilk;
            this.ibShare.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.ibShare.IconColor = System.Drawing.Color.Cornsilk;
            this.ibShare.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibShare.IconSize = 25;
            this.ibShare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibShare.Location = new System.Drawing.Point(16, 28);
            this.ibShare.Name = "ibShare";
            this.ibShare.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.ibShare.Size = new System.Drawing.Size(114, 30);
            this.ibShare.TabIndex = 13;
            this.ibShare.Text = "Share";
            this.ibShare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibShare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibShare.UseVisualStyleBackColor = true;
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContentPanel.Location = new System.Drawing.Point(183, 80);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(815, 554);
            this.mainContentPanel.TabIndex = 5;
            // 
            // Maineditorwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 634);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Maineditorwindow";
            this.Text = "Basy";
            this.Load += new System.EventHandler(this.Maineditorwindow_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblCurrentControl;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton ibTemplates;
        private FontAwesome.Sharp.IconButton ibHowTo;
        private FontAwesome.Sharp.IconButton ibHistory;
        private FontAwesome.Sharp.IconButton ibSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainContentPanel;
        private FontAwesome.Sharp.IconButton ibShare;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}