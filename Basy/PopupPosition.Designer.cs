namespace Basy
{
    partial class PopupPosition
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
            this.btnLeftTop = new System.Windows.Forms.Button();
            this.btnLeftBottom = new System.Windows.Forms.Button();
            this.btnRightTop = new System.Windows.Forms.Button();
            this.btnRightBottom = new System.Windows.Forms.Button();
            this.btnCoursorPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeftTop
            // 
            this.btnLeftTop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeftTop.Location = new System.Drawing.Point(12, 12);
            this.btnLeftTop.Name = "btnLeftTop";
            this.btnLeftTop.Size = new System.Drawing.Size(132, 40);
            this.btnLeftTop.TabIndex = 0;
            this.btnLeftTop.Text = "Top Left";
            this.btnLeftTop.UseVisualStyleBackColor = true;
            this.btnLeftTop.Click += new System.EventHandler(this.btnCoursorPosition_Click);
            // 
            // btnLeftBottom
            // 
            this.btnLeftBottom.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeftBottom.Location = new System.Drawing.Point(12, 197);
            this.btnLeftBottom.Name = "btnLeftBottom";
            this.btnLeftBottom.Size = new System.Drawing.Size(132, 47);
            this.btnLeftBottom.TabIndex = 1;
            this.btnLeftBottom.Text = "Bottom Left";
            this.btnLeftBottom.UseVisualStyleBackColor = true;
            this.btnLeftBottom.Click += new System.EventHandler(this.btnCoursorPosition_Click);
            // 
            // btnRightTop
            // 
            this.btnRightTop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRightTop.Location = new System.Drawing.Point(343, 12);
            this.btnRightTop.Name = "btnRightTop";
            this.btnRightTop.Size = new System.Drawing.Size(132, 40);
            this.btnRightTop.TabIndex = 2;
            this.btnRightTop.Text = "Top Right";
            this.btnRightTop.UseVisualStyleBackColor = true;
            this.btnRightTop.Click += new System.EventHandler(this.btnCoursorPosition_Click);
            // 
            // btnRightBottom
            // 
            this.btnRightBottom.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRightBottom.Location = new System.Drawing.Point(343, 204);
            this.btnRightBottom.Name = "btnRightBottom";
            this.btnRightBottom.Size = new System.Drawing.Size(132, 40);
            this.btnRightBottom.TabIndex = 3;
            this.btnRightBottom.Text = "Bottom Right";
            this.btnRightBottom.UseVisualStyleBackColor = true;
            this.btnRightBottom.Click += new System.EventHandler(this.btnCoursorPosition_Click);
            // 
            // btnCoursorPosition
            // 
            this.btnCoursorPosition.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoursorPosition.Location = new System.Drawing.Point(181, 106);
            this.btnCoursorPosition.Name = "btnCoursorPosition";
            this.btnCoursorPosition.Size = new System.Drawing.Size(132, 51);
            this.btnCoursorPosition.TabIndex = 4;
            this.btnCoursorPosition.Text = "Coursor Position";
            this.btnCoursorPosition.UseVisualStyleBackColor = true;
            this.btnCoursorPosition.Click += new System.EventHandler(this.btnCoursorPosition_Click);
            // 
            // PopupPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 256);
            this.Controls.Add(this.btnCoursorPosition);
            this.Controls.Add(this.btnRightBottom);
            this.Controls.Add(this.btnRightTop);
            this.Controls.Add(this.btnLeftBottom);
            this.Controls.Add(this.btnLeftTop);
            this.Name = "PopupPosition";
            this.Text = "PopupPosition";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeftTop;
        private System.Windows.Forms.Button btnLeftBottom;
        private System.Windows.Forms.Button btnRightTop;
        private System.Windows.Forms.Button btnRightBottom;
        private System.Windows.Forms.Button btnCoursorPosition;
    }
}