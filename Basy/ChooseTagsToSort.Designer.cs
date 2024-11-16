namespace Basy
{
    partial class ChooseTagsToSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTagsToSort));
            this.lblChooseTags = new System.Windows.Forms.Label();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.mtbSort = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblChooseTags
            // 
            this.lblChooseTags.AutoSize = true;
            this.lblChooseTags.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseTags.Location = new System.Drawing.Point(12, 15);
            this.lblChooseTags.Name = "lblChooseTags";
            this.lblChooseTags.Size = new System.Drawing.Size(252, 23);
            this.lblChooseTags.TabIndex = 15;
            this.lblChooseTags.Text = "Please select Tags to sort";
            // 
            // lbTags
            // 
            this.lbTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 24;
            this.lbTags.Location = new System.Drawing.Point(12, 67);
            this.lbTags.Name = "lbTags";
            this.lbTags.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTags.Size = new System.Drawing.Size(330, 316);
            this.lbTags.TabIndex = 17;
            // 
            // mtbSort
            // 
            this.mtbSort.AutoSize = false;
            this.mtbSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtbSort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mtbSort.Depth = 0;
            this.mtbSort.HighEmphasis = true;
            this.mtbSort.Icon = null;
            this.mtbSort.Location = new System.Drawing.Point(13, 401);
            this.mtbSort.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mtbSort.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtbSort.Name = "mtbSort";
            this.mtbSort.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mtbSort.Size = new System.Drawing.Size(92, 34);
            this.mtbSort.TabIndex = 18;
            this.mtbSort.Text = "Sort";
            this.mtbSort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mtbSort.UseAccentColor = false;
            this.mtbSort.UseVisualStyleBackColor = true;
            this.mtbSort.Click += new System.EventHandler(this.mtbSort_Click);
            // 
            // ChooseTagsToSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.mtbSort);
            this.Controls.Add(this.lbTags);
            this.Controls.Add(this.lblChooseTags);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseTagsToSort";
            this.Text = "Choose Tags";
            this.Load += new System.EventHandler(this.ChooseTagsToSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChooseTags;
        private System.Windows.Forms.ListBox lbTags;
        private MaterialSkin.Controls.MaterialButton mtbSort;
    }
}