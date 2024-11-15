namespace Basy
{
    partial class ShortCutWindow
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
            this.tbHotkeyTemplates = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbHotkeyTemplates
            // 
            this.tbHotkeyTemplates.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHotkeyTemplates.Location = new System.Drawing.Point(12, 12);
            this.tbHotkeyTemplates.Name = "tbHotkeyTemplates";
            this.tbHotkeyTemplates.Size = new System.Drawing.Size(331, 31);
            this.tbHotkeyTemplates.TabIndex = 15;
            this.tbHotkeyTemplates.TextChanged += new System.EventHandler(this.tbHotkeyTemplates_TextChanged);
            this.tbHotkeyTemplates.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbHotkeyTemplates_KeyDown);
            this.tbHotkeyTemplates.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbHotkeyTemplates_KeyUp);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(363, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 28);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ShortCutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 53);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbHotkeyTemplates);
            this.Name = "ShortCutWindow";
            this.Text = "ShortCutWindow";
            this.Load += new System.EventHandler(this.ShortCutWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHotkeyTemplates;
        private System.Windows.Forms.Button btnSave;
    }
}