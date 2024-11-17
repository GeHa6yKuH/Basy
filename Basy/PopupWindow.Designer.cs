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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupWindow));
            this.lbTemplates = new System.Windows.Forms.ListBox();
            this.cbSortBox = new System.Windows.Forms.ComboBox();
            this.mtbOpenEditor = new MaterialSkin.Controls.MaterialButton();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.pnlUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTemplates
            // 
            this.lbTemplates.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbTemplates.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTemplates.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTemplates.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTemplates.FormattingEnabled = true;
            this.lbTemplates.ItemHeight = 23;
            this.lbTemplates.Location = new System.Drawing.Point(0, 58);
            this.lbTemplates.Name = "lbTemplates";
            this.lbTemplates.Size = new System.Drawing.Size(310, 441);
            this.lbTemplates.TabIndex = 0;
            // 
            // cbSortBox
            // 
            this.cbSortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSortBox.FormattingEnabled = true;
            this.cbSortBox.Items.AddRange(new object[] {
            "Name (A - Z)",
            "Name (Z - A)",
            "Creation date (new to old)",
            "Tags (more to less tags)",
            "Tags (choose tags)"});
            this.cbSortBox.Location = new System.Drawing.Point(9, 15);
            this.cbSortBox.Margin = new System.Windows.Forms.Padding(0);
            this.cbSortBox.Name = "cbSortBox";
            this.cbSortBox.Size = new System.Drawing.Size(148, 28);
            this.cbSortBox.TabIndex = 13;
            this.cbSortBox.SelectedIndexChanged += new System.EventHandler(this.cbSortGrid_SelectedIndexChanged);
            // 
            // mtbOpenEditor
            // 
            this.mtbOpenEditor.AutoSize = false;
            this.mtbOpenEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbOpenEditor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbOpenEditor.Depth = 0;
            this.mtbOpenEditor.HighEmphasis = true;
            this.mtbOpenEditor.Icon = null;
            this.mtbOpenEditor.Location = new System.Drawing.Point(174, 10);
            this.mtbOpenEditor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbOpenEditor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbOpenEditor.Name = "mtbOpenEditor";
            this.mtbOpenEditor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbOpenEditor.Size = new System.Drawing.Size(123, 33);
            this.mtbOpenEditor.TabIndex = 14;
            this.mtbOpenEditor.Text = "Open Editor";
            this.mtbOpenEditor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbOpenEditor.UseAccentColor = false;
            this.mtbOpenEditor.UseVisualStyleBackColor = true;
            this.mtbOpenEditor.Click += new System.EventHandler(this.mtbOpenEditor_Click);
            // 
            // pnlUpper
            // 
            this.pnlUpper.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlUpper.Controls.Add(this.cbSortBox);
            this.pnlUpper.Controls.Add(this.mtbOpenEditor);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(310, 59);
            this.pnlUpper.TabIndex = 15;
            // 
            // PopupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(310, 499);
            this.Controls.Add(this.pnlUpper);
            this.Controls.Add(this.lbTemplates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopupWindow";
            this.Text = "PopupWindow";
            this.Load += new System.EventHandler(this.PopupWindow_Load);
            this.pnlUpper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTemplates;
        private System.Windows.Forms.ComboBox cbSortBox;
        private MaterialSkin.Controls.MaterialButton mtbOpenEditor;
        private System.Windows.Forms.Panel pnlUpper;
    }
}