namespace Basy
{
    partial class NewTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTemplate));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.mtbAdd = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // tbText
            // 
            resources.ApplyResources(this.tbText, "tbText");
            this.tbText.Name = "tbText";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblText
            // 
            resources.ApplyResources(this.lblText, "lblText");
            this.lblText.Name = "lblText";
            // 
            // mtbAdd
            // 
            resources.ApplyResources(this.mtbAdd, "mtbAdd");
            this.mtbAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbAdd.Depth = 0;
            this.mtbAdd.HighEmphasis = true;
            this.mtbAdd.Icon = null;
            this.mtbAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbAdd.Name = "mtbAdd";
            this.mtbAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbAdd.UseAccentColor = false;
            this.mtbAdd.UseVisualStyleBackColor = true;
            this.mtbAdd.Click += new System.EventHandler(this.mtbAdd_Click);
            // 
            // NewTemplate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.mtbAdd);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbName);
            this.Name = "NewTemplate";
            this.Load += new System.EventHandler(this.NewTemplate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblText;
        private MaterialSkin.Controls.MaterialButton mtbAdd;
    }
}