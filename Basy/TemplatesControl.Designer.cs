namespace Basy
{
    partial class TemplatesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTemplates = new System.Windows.Forms.Label();
            this.cbSortGrid = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.dGVTemplates = new System.Windows.Forms.DataGridView();
            this.mbtnDelete = new MaterialSkin.Controls.MaterialButton();
            this.mbtnAdd = new MaterialSkin.Controls.MaterialButton();
            this.mbtnEditTags = new MaterialSkin.Controls.MaterialButton();
            this.mbtnUpdateGrid = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemplates
            // 
            this.lblTemplates.AutoSize = true;
            this.lblTemplates.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemplates.Location = new System.Drawing.Point(19, 27);
            this.lblTemplates.Name = "lblTemplates";
            this.lblTemplates.Size = new System.Drawing.Size(151, 32);
            this.lblTemplates.TabIndex = 7;
            this.lblTemplates.Text = "Templates";
            // 
            // cbSortGrid
            // 
            this.cbSortGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSortGrid.BackColor = System.Drawing.Color.Azure;
            this.cbSortGrid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSortGrid.FormattingEnabled = true;
            this.cbSortGrid.Items.AddRange(new object[] {
            "Name (A - Z)",
            "Name (Z - A)",
            "Creation date (new to old)",
            "Tags (more to less tags)",
            "Tags (choose tags)"});
            this.cbSortGrid.Location = new System.Drawing.Point(403, 63);
            this.cbSortGrid.Name = "cbSortGrid";
            this.cbSortGrid.Size = new System.Drawing.Size(188, 28);
            this.cbSortGrid.TabIndex = 12;
            this.cbSortGrid.SelectedIndexChanged += new System.EventHandler(this.cbSortGrid_SelectedIndexChanged);
            // 
            // lblSortBy
            // 
            this.lblSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortBy.Location = new System.Drawing.Point(400, 27);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(77, 18);
            this.lblSortBy.TabIndex = 13;
            this.lblSortBy.Text = "Sort by:";
            // 
            // dGVTemplates
            // 
            this.dGVTemplates.AllowUserToAddRows = false;
            this.dGVTemplates.AllowUserToDeleteRows = false;
            this.dGVTemplates.AllowUserToResizeColumns = false;
            this.dGVTemplates.AllowUserToResizeRows = false;
            this.dGVTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVTemplates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dGVTemplates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVTemplates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVTemplates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVTemplates.ColumnHeadersHeight = 50;
            this.dGVTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVTemplates.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVTemplates.EnableHeadersVisualStyles = false;
            this.dGVTemplates.GridColor = System.Drawing.Color.SteelBlue;
            this.dGVTemplates.Location = new System.Drawing.Point(25, 114);
            this.dGVTemplates.Name = "dGVTemplates";
            this.dGVTemplates.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVTemplates.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVTemplates.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVTemplates.RowTemplate.Height = 40;
            this.dGVTemplates.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dGVTemplates.Size = new System.Drawing.Size(758, 371);
            this.dGVTemplates.TabIndex = 14;
            this.dGVTemplates.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVTemplates_CellMouseClick);
            // 
            // mbtnDelete
            // 
            this.mbtnDelete.AutoSize = false;
            this.mbtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mbtnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnDelete.Depth = 0;
            this.mbtnDelete.FlatAppearance.BorderSize = 0;
            this.mbtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mbtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mbtnDelete.HighEmphasis = true;
            this.mbtnDelete.Icon = null;
            this.mbtnDelete.Location = new System.Drawing.Point(622, 60);
            this.mbtnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnDelete.Name = "mbtnDelete";
            this.mbtnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnDelete.Size = new System.Drawing.Size(86, 31);
            this.mbtnDelete.TabIndex = 15;
            this.mbtnDelete.Text = "Delete";
            this.mbtnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnDelete.UseAccentColor = false;
            this.mbtnDelete.UseVisualStyleBackColor = false;
            this.mbtnDelete.Click += new System.EventHandler(this.mbtnDelete_Click);
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.AutoSize = false;
            this.mbtnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mbtnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnAdd.Depth = 0;
            this.mbtnAdd.FlatAppearance.BorderSize = 0;
            this.mbtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mbtnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mbtnAdd.HighEmphasis = true;
            this.mbtnAdd.Icon = null;
            this.mbtnAdd.Location = new System.Drawing.Point(729, 60);
            this.mbtnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnAdd.Size = new System.Drawing.Size(54, 31);
            this.mbtnAdd.TabIndex = 16;
            this.mbtnAdd.Text = "+";
            this.mbtnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnAdd.UseAccentColor = false;
            this.mbtnAdd.UseVisualStyleBackColor = false;
            this.mbtnAdd.Click += new System.EventHandler(this.mbtnAdd_Click);
            // 
            // mbtnEditTags
            // 
            this.mbtnEditTags.AutoSize = false;
            this.mbtnEditTags.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnEditTags.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mbtnEditTags.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnEditTags.Depth = 0;
            this.mbtnEditTags.FlatAppearance.BorderSize = 0;
            this.mbtnEditTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtnEditTags.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mbtnEditTags.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mbtnEditTags.HighEmphasis = true;
            this.mbtnEditTags.Icon = null;
            this.mbtnEditTags.Location = new System.Drawing.Point(25, 505);
            this.mbtnEditTags.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnEditTags.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnEditTags.Name = "mbtnEditTags";
            this.mbtnEditTags.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnEditTags.Size = new System.Drawing.Size(95, 25);
            this.mbtnEditTags.TabIndex = 17;
            this.mbtnEditTags.Text = "Edit Tags";
            this.mbtnEditTags.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnEditTags.UseAccentColor = false;
            this.mbtnEditTags.UseVisualStyleBackColor = false;
            this.mbtnEditTags.Click += new System.EventHandler(this.mbtnEditTags_Click);
            // 
            // mbtnUpdateGrid
            // 
            this.mbtnUpdateGrid.AutoSize = false;
            this.mbtnUpdateGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnUpdateGrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mbtnUpdateGrid.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnUpdateGrid.Depth = 0;
            this.mbtnUpdateGrid.FlatAppearance.BorderSize = 0;
            this.mbtnUpdateGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtnUpdateGrid.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mbtnUpdateGrid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mbtnUpdateGrid.HighEmphasis = true;
            this.mbtnUpdateGrid.Icon = null;
            this.mbtnUpdateGrid.Location = new System.Drawing.Point(668, 505);
            this.mbtnUpdateGrid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnUpdateGrid.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnUpdateGrid.Name = "mbtnUpdateGrid";
            this.mbtnUpdateGrid.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnUpdateGrid.Size = new System.Drawing.Size(115, 25);
            this.mbtnUpdateGrid.TabIndex = 18;
            this.mbtnUpdateGrid.Text = "Update Table";
            this.mbtnUpdateGrid.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnUpdateGrid.UseAccentColor = false;
            this.mbtnUpdateGrid.UseVisualStyleBackColor = false;
            this.mbtnUpdateGrid.Click += new System.EventHandler(this.mbtnUpdateGrid_Click);
            // 
            // TemplatesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.mbtnUpdateGrid);
            this.Controls.Add(this.mbtnEditTags);
            this.Controls.Add(this.mbtnAdd);
            this.Controls.Add(this.mbtnDelete);
            this.Controls.Add(this.dGVTemplates);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.cbSortGrid);
            this.Controls.Add(this.lblTemplates);
            this.Name = "TemplatesControl";
            this.Size = new System.Drawing.Size(815, 554);
            this.Load += new System.EventHandler(this.TemplatesControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTemplates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTemplates;
        private System.Windows.Forms.ComboBox cbSortGrid;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.DataGridView dGVTemplates;
        private MaterialSkin.Controls.MaterialButton mbtnDelete;
        private MaterialSkin.Controls.MaterialButton mbtnAdd;
        private MaterialSkin.Controls.MaterialButton mbtnEditTags;
        private MaterialSkin.Controls.MaterialButton mbtnUpdateGrid;
    }
}
