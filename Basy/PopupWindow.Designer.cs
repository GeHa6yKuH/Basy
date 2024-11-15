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
            this.btnEditorOpen = new System.Windows.Forms.Button();
            this.cbSortBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbTemplates
            // 
            this.lbTemplates.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTemplates.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTemplates.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbTemplates.FormattingEnabled = true;
            this.lbTemplates.ItemHeight = 18;
            this.lbTemplates.Location = new System.Drawing.Point(1, 34);
            this.lbTemplates.Name = "lbTemplates";
            this.lbTemplates.Size = new System.Drawing.Size(311, 436);
            this.lbTemplates.TabIndex = 0;
            // 
            // btnEditorOpen
            // 
            this.btnEditorOpen.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEditorOpen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditorOpen.Location = new System.Drawing.Point(203, 5);
            this.btnEditorOpen.Name = "btnEditorOpen";
            this.btnEditorOpen.Size = new System.Drawing.Size(98, 23);
            this.btnEditorOpen.TabIndex = 1;
            this.btnEditorOpen.Text = "Open Editor";
            this.btnEditorOpen.UseVisualStyleBackColor = false;
            this.btnEditorOpen.Click += new System.EventHandler(this.btnEditorOpen_Click);
            // 
            // cbSortBox
            // 
            this.cbSortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSortBox.FormattingEnabled = true;
            this.cbSortBox.Items.AddRange(new object[] {
            "Name (A - Z)",
            "Name (Z - A)",
            "Creation date (new to old)",
            "Tags (more to less tags)",
            "Tags (choose tags)"});
            this.cbSortBox.Location = new System.Drawing.Point(5, 5);
            this.cbSortBox.Margin = new System.Windows.Forms.Padding(0);
            this.cbSortBox.Name = "cbSortBox";
            this.cbSortBox.Size = new System.Drawing.Size(114, 23);
            this.cbSortBox.TabIndex = 13;
            this.cbSortBox.SelectedIndexChanged += new System.EventHandler(this.cbSortGrid_SelectedIndexChanged);
            // 
            // PopupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 472);
            this.Controls.Add(this.cbSortBox);
            this.Controls.Add(this.btnEditorOpen);
            this.Controls.Add(this.lbTemplates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupWindow";
            this.Text = "PopupWindow";
            this.Load += new System.EventHandler(this.PopupWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTemplates;
        private System.Windows.Forms.Button btnEditorOpen;
        private System.Windows.Forms.ComboBox cbSortBox;
    }
}