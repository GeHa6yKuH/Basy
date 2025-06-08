namespace Basy
{
    partial class PackagesControl
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
            this.lblHistory = new System.Windows.Forms.Label();
            this.sfbtnAdd = new Syncfusion.WinForms.Controls.SfButton();
            this.sfbtnCreate = new Syncfusion.WinForms.Controls.SfButton();
            this.dGVPackages = new System.Windows.Forms.DataGridView();
            this.sfBtnDelete = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHistory.Location = new System.Drawing.Point(24, 23);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(138, 32);
            this.lblHistory.TabIndex = 10;
            this.lblHistory.Text = "Packages";
            // 
            // sfbtnAdd
            // 
            this.sfbtnAdd.BackColor = System.Drawing.Color.Cyan;
            this.sfbtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.sfbtnAdd.Location = new System.Drawing.Point(30, 99);
            this.sfbtnAdd.Name = "sfbtnAdd";
            this.sfbtnAdd.Size = new System.Drawing.Size(84, 42);
            this.sfbtnAdd.Style.BackColor = System.Drawing.Color.Cyan;
            this.sfbtnAdd.TabIndex = 11;
            this.sfbtnAdd.Text = "Add";
            this.sfbtnAdd.UseVisualStyleBackColor = false;
            this.sfbtnAdd.Click += new System.EventHandler(this.sfbtnAddFromRemote_Click);
            // 
            // sfbtnCreate
            // 
            this.sfbtnCreate.BackColor = System.Drawing.Color.Cyan;
            this.sfbtnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.sfbtnCreate.Location = new System.Drawing.Point(152, 99);
            this.sfbtnCreate.Name = "sfbtnCreate";
            this.sfbtnCreate.Size = new System.Drawing.Size(105, 42);
            this.sfbtnCreate.Style.BackColor = System.Drawing.Color.Cyan;
            this.sfbtnCreate.TabIndex = 12;
            this.sfbtnCreate.Text = "Create";
            this.sfbtnCreate.UseVisualStyleBackColor = false;
            this.sfbtnCreate.Click += new System.EventHandler(this.sfbtnCreate_Click);
            // 
            // dGVPackages
            // 
            this.dGVPackages.AllowUserToAddRows = false;
            this.dGVPackages.AllowUserToDeleteRows = false;
            this.dGVPackages.AllowUserToResizeColumns = false;
            this.dGVPackages.AllowUserToResizeRows = false;
            this.dGVPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVPackages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dGVPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVPackages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVPackages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVPackages.ColumnHeadersHeight = 50;
            this.dGVPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVPackages.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVPackages.EnableHeadersVisualStyles = false;
            this.dGVPackages.GridColor = System.Drawing.Color.SteelBlue;
            this.dGVPackages.Location = new System.Drawing.Point(30, 202);
            this.dGVPackages.Name = "dGVPackages";
            this.dGVPackages.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVPackages.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVPackages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVPackages.RowTemplate.Height = 40;
            this.dGVPackages.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dGVPackages.Size = new System.Drawing.Size(730, 293);
            this.dGVPackages.TabIndex = 15;
            // 
            // sfBtnDelete
            // 
            this.sfBtnDelete.BackColor = System.Drawing.Color.Cyan;
            this.sfBtnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.sfBtnDelete.Location = new System.Drawing.Point(655, 99);
            this.sfBtnDelete.Name = "sfBtnDelete";
            this.sfBtnDelete.Size = new System.Drawing.Size(105, 42);
            this.sfBtnDelete.Style.BackColor = System.Drawing.Color.Cyan;
            this.sfBtnDelete.TabIndex = 16;
            this.sfBtnDelete.Text = "Delete";
            this.sfBtnDelete.UseVisualStyleBackColor = false;
            this.sfBtnDelete.Click += new System.EventHandler(this.sfBtnDelete_Click);
            // 
            // PackagesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.sfBtnDelete);
            this.Controls.Add(this.dGVPackages);
            this.Controls.Add(this.sfbtnCreate);
            this.Controls.Add(this.sfbtnAdd);
            this.Controls.Add(this.lblHistory);
            this.Name = "PackagesControl";
            this.Size = new System.Drawing.Size(815, 554);
            this.Load += new System.EventHandler(this.PackagesControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPackages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistory;
        private Syncfusion.WinForms.Controls.SfButton sfbtnAdd;
        private Syncfusion.WinForms.Controls.SfButton sfbtnCreate;
        private System.Windows.Forms.DataGridView dGVPackages;
        private Syncfusion.WinForms.Controls.SfButton sfBtnDelete;
    }
}
