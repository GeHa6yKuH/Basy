namespace Basy
{
    partial class SettingsControl
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
            this.lblSettings = new System.Windows.Forms.Label();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblStartWithEditor = new System.Windows.Forms.Label();
            this.rbStartWithSystem = new System.Windows.Forms.RadioButton();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lblStartOnSystem = new System.Windows.Forms.Label();
            this.pnlHotkeys = new System.Windows.Forms.Panel();
            this.btnEditOpenMainEditor = new System.Windows.Forms.Button();
            this.btnEditOpenClipboardPopup = new System.Windows.Forms.Button();
            this.btnEditOpenTemplatesPopup = new System.Windows.Forms.Button();
            this.tbHotkeyMainEditor = new System.Windows.Forms.TextBox();
            this.tbHotkeyClipboard = new System.Windows.Forms.TextBox();
            this.tbHotkeyTemplates = new System.Windows.Forms.TextBox();
            this.lblOpenEditor = new System.Windows.Forms.Label();
            this.lblOpenClipboardPopup = new System.Windows.Forms.Label();
            this.lblHotkeys = new System.Windows.Forms.Label();
            this.lblOpenTemplatePopup = new System.Windows.Forms.Label();
            this.pnlPopups = new System.Windows.Forms.Panel();
            this.rbShowTemplateTextOnHover = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbShowVersionsOnHover = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPositionClip = new System.Windows.Forms.Button();
            this.lblClipboardPopupPosition = new System.Windows.Forms.Label();
            this.btnPositionTemp = new System.Windows.Forms.Button();
            this.rbSaveImagesToClips = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPopupWindows = new System.Windows.Forms.Label();
            this.lblTemplatesPopupPosition = new System.Windows.Forms.Label();
            this.btnSetAllDefaults = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGeneral.SuspendLayout();
            this.pnlHotkeys.SuspendLayout();
            this.pnlPopups.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSettings.Location = new System.Drawing.Point(12, 19);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(125, 32);
            this.lblSettings.TabIndex = 8;
            this.lblSettings.Text = "Settings";
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGeneral.Controls.Add(this.radioButton1);
            this.pnlGeneral.Controls.Add(this.lblStartWithEditor);
            this.pnlGeneral.Controls.Add(this.rbStartWithSystem);
            this.pnlGeneral.Controls.Add(this.lblGeneral);
            this.pnlGeneral.Controls.Add(this.lblStartOnSystem);
            this.pnlGeneral.Location = new System.Drawing.Point(18, 126);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(485, 143);
            this.pnlGeneral.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(224, 102);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(18, 23);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblStartWithEditor
            // 
            this.lblStartWithEditor.AutoSize = true;
            this.lblStartWithEditor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartWithEditor.Location = new System.Drawing.Point(16, 102);
            this.lblStartWithEditor.Name = "lblStartWithEditor";
            this.lblStartWithEditor.Size = new System.Drawing.Size(176, 18);
            this.lblStartWithEditor.TabIndex = 12;
            this.lblStartWithEditor.Text = "Open Editor on start";
            this.lblStartWithEditor.Click += new System.EventHandler(this.lblStartWithEditor_Click);
            // 
            // rbStartWithSystem
            // 
            this.rbStartWithSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbStartWithSystem.Location = new System.Drawing.Point(224, 62);
            this.rbStartWithSystem.Name = "rbStartWithSystem";
            this.rbStartWithSystem.Size = new System.Drawing.Size(18, 23);
            this.rbStartWithSystem.TabIndex = 11;
            this.rbStartWithSystem.TabStop = true;
            this.rbStartWithSystem.UseVisualStyleBackColor = true;
            this.rbStartWithSystem.CheckedChanged += new System.EventHandler(this.rbStartWithSystem_CheckedChanged);
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGeneral.Location = new System.Drawing.Point(14, 11);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(95, 25);
            this.lblGeneral.TabIndex = 10;
            this.lblGeneral.Text = "General";
            // 
            // lblStartOnSystem
            // 
            this.lblStartOnSystem.AutoSize = true;
            this.lblStartOnSystem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartOnSystem.Location = new System.Drawing.Point(16, 62);
            this.lblStartOnSystem.Name = "lblStartOnSystem";
            this.lblStartOnSystem.Size = new System.Drawing.Size(154, 18);
            this.lblStartOnSystem.TabIndex = 9;
            this.lblStartOnSystem.Text = "Start with system";
            // 
            // pnlHotkeys
            // 
            this.pnlHotkeys.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlHotkeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHotkeys.Controls.Add(this.btnEditOpenMainEditor);
            this.pnlHotkeys.Controls.Add(this.btnEditOpenClipboardPopup);
            this.pnlHotkeys.Controls.Add(this.btnEditOpenTemplatesPopup);
            this.pnlHotkeys.Controls.Add(this.tbHotkeyMainEditor);
            this.pnlHotkeys.Controls.Add(this.tbHotkeyClipboard);
            this.pnlHotkeys.Controls.Add(this.tbHotkeyTemplates);
            this.pnlHotkeys.Controls.Add(this.lblOpenEditor);
            this.pnlHotkeys.Controls.Add(this.lblOpenClipboardPopup);
            this.pnlHotkeys.Controls.Add(this.lblHotkeys);
            this.pnlHotkeys.Controls.Add(this.lblOpenTemplatePopup);
            this.pnlHotkeys.Location = new System.Drawing.Point(18, 290);
            this.pnlHotkeys.Name = "pnlHotkeys";
            this.pnlHotkeys.Size = new System.Drawing.Size(485, 194);
            this.pnlHotkeys.TabIndex = 10;
            // 
            // btnEditOpenMainEditor
            // 
            this.btnEditOpenMainEditor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditOpenMainEditor.Location = new System.Drawing.Point(400, 143);
            this.btnEditOpenMainEditor.Name = "btnEditOpenMainEditor";
            this.btnEditOpenMainEditor.Size = new System.Drawing.Size(61, 27);
            this.btnEditOpenMainEditor.TabIndex = 19;
            this.btnEditOpenMainEditor.Text = "Edit";
            this.btnEditOpenMainEditor.UseVisualStyleBackColor = true;
            // 
            // btnEditOpenClipboardPopup
            // 
            this.btnEditOpenClipboardPopup.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditOpenClipboardPopup.Location = new System.Drawing.Point(400, 96);
            this.btnEditOpenClipboardPopup.Name = "btnEditOpenClipboardPopup";
            this.btnEditOpenClipboardPopup.Size = new System.Drawing.Size(61, 27);
            this.btnEditOpenClipboardPopup.TabIndex = 18;
            this.btnEditOpenClipboardPopup.Text = "Edit";
            this.btnEditOpenClipboardPopup.UseVisualStyleBackColor = true;
            // 
            // btnEditOpenTemplatesPopup
            // 
            this.btnEditOpenTemplatesPopup.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditOpenTemplatesPopup.Location = new System.Drawing.Point(400, 50);
            this.btnEditOpenTemplatesPopup.Name = "btnEditOpenTemplatesPopup";
            this.btnEditOpenTemplatesPopup.Size = new System.Drawing.Size(61, 27);
            this.btnEditOpenTemplatesPopup.TabIndex = 17;
            this.btnEditOpenTemplatesPopup.Text = "Edit";
            this.btnEditOpenTemplatesPopup.UseVisualStyleBackColor = true;
            // 
            // tbHotkeyMainEditor
            // 
            this.tbHotkeyMainEditor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHotkeyMainEditor.Location = new System.Drawing.Point(224, 143);
            this.tbHotkeyMainEditor.Name = "tbHotkeyMainEditor";
            this.tbHotkeyMainEditor.Size = new System.Drawing.Size(170, 27);
            this.tbHotkeyMainEditor.TabIndex = 16;
            // 
            // tbHotkeyClipboard
            // 
            this.tbHotkeyClipboard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHotkeyClipboard.Location = new System.Drawing.Point(224, 96);
            this.tbHotkeyClipboard.Name = "tbHotkeyClipboard";
            this.tbHotkeyClipboard.Size = new System.Drawing.Size(170, 27);
            this.tbHotkeyClipboard.TabIndex = 15;
            // 
            // tbHotkeyTemplates
            // 
            this.tbHotkeyTemplates.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHotkeyTemplates.Location = new System.Drawing.Point(224, 50);
            this.tbHotkeyTemplates.Name = "tbHotkeyTemplates";
            this.tbHotkeyTemplates.Size = new System.Drawing.Size(170, 27);
            this.tbHotkeyTemplates.TabIndex = 14;
            // 
            // lblOpenEditor
            // 
            this.lblOpenEditor.AutoSize = true;
            this.lblOpenEditor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpenEditor.Location = new System.Drawing.Point(16, 146);
            this.lblOpenEditor.Name = "lblOpenEditor";
            this.lblOpenEditor.Size = new System.Drawing.Size(149, 18);
            this.lblOpenEditor.TabIndex = 13;
            this.lblOpenEditor.Text = "Open Main Editor";
            // 
            // lblOpenClipboardPopup
            // 
            this.lblOpenClipboardPopup.AutoSize = true;
            this.lblOpenClipboardPopup.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpenClipboardPopup.Location = new System.Drawing.Point(16, 99);
            this.lblOpenClipboardPopup.Name = "lblOpenClipboardPopup";
            this.lblOpenClipboardPopup.Size = new System.Drawing.Size(190, 18);
            this.lblOpenClipboardPopup.TabIndex = 12;
            this.lblOpenClipboardPopup.Text = "Open Clipboard Popup";
            // 
            // lblHotkeys
            // 
            this.lblHotkeys.AutoSize = true;
            this.lblHotkeys.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHotkeys.Location = new System.Drawing.Point(14, 13);
            this.lblHotkeys.Name = "lblHotkeys";
            this.lblHotkeys.Size = new System.Drawing.Size(97, 25);
            this.lblHotkeys.TabIndex = 10;
            this.lblHotkeys.Text = "Hotkeys";
            this.lblHotkeys.Click += new System.EventHandler(this.lblHotkeys_Click);
            // 
            // lblOpenTemplatePopup
            // 
            this.lblOpenTemplatePopup.AutoSize = true;
            this.lblOpenTemplatePopup.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpenTemplatePopup.Location = new System.Drawing.Point(16, 53);
            this.lblOpenTemplatePopup.Name = "lblOpenTemplatePopup";
            this.lblOpenTemplatePopup.Size = new System.Drawing.Size(197, 18);
            this.lblOpenTemplatePopup.TabIndex = 9;
            this.lblOpenTemplatePopup.Text = "Open Templates Popup";
            // 
            // pnlPopups
            // 
            this.pnlPopups.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlPopups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPopups.Controls.Add(this.rbShowTemplateTextOnHover);
            this.pnlPopups.Controls.Add(this.label3);
            this.pnlPopups.Controls.Add(this.rbShowVersionsOnHover);
            this.pnlPopups.Controls.Add(this.label2);
            this.pnlPopups.Controls.Add(this.btnPositionClip);
            this.pnlPopups.Controls.Add(this.lblClipboardPopupPosition);
            this.pnlPopups.Controls.Add(this.btnPositionTemp);
            this.pnlPopups.Controls.Add(this.rbSaveImagesToClips);
            this.pnlPopups.Controls.Add(this.label1);
            this.pnlPopups.Controls.Add(this.lblPopupWindows);
            this.pnlPopups.Controls.Add(this.lblTemplatesPopupPosition);
            this.pnlPopups.Location = new System.Drawing.Point(18, 509);
            this.pnlPopups.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.pnlPopups.Name = "pnlPopups";
            this.pnlPopups.Size = new System.Drawing.Size(485, 276);
            this.pnlPopups.TabIndex = 11;
            // 
            // rbShowTemplateTextOnHover
            // 
            this.rbShowTemplateTextOnHover.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbShowTemplateTextOnHover.Location = new System.Drawing.Point(312, 233);
            this.rbShowTemplateTextOnHover.Name = "rbShowTemplateTextOnHover";
            this.rbShowTemplateTextOnHover.Size = new System.Drawing.Size(18, 23);
            this.rbShowTemplateTextOnHover.TabIndex = 20;
            this.rbShowTemplateTextOnHover.TabStop = true;
            this.rbShowTemplateTextOnHover.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Show Template Text On Hover";
            // 
            // rbShowVersionsOnHover
            // 
            this.rbShowVersionsOnHover.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbShowVersionsOnHover.Location = new System.Drawing.Point(312, 199);
            this.rbShowVersionsOnHover.Name = "rbShowVersionsOnHover";
            this.rbShowVersionsOnHover.Size = new System.Drawing.Size(18, 23);
            this.rbShowVersionsOnHover.TabIndex = 18;
            this.rbShowVersionsOnHover.TabStop = true;
            this.rbShowVersionsOnHover.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Show Versions On Hover";
            // 
            // btnPositionClip
            // 
            this.btnPositionClip.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPositionClip.Location = new System.Drawing.Point(256, 98);
            this.btnPositionClip.Name = "btnPositionClip";
            this.btnPositionClip.Size = new System.Drawing.Size(107, 28);
            this.btnPositionClip.TabIndex = 16;
            this.btnPositionClip.Text = "Position";
            this.btnPositionClip.UseVisualStyleBackColor = true;
            // 
            // lblClipboardPopupPosition
            // 
            this.lblClipboardPopupPosition.AutoSize = true;
            this.lblClipboardPopupPosition.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClipboardPopupPosition.Location = new System.Drawing.Point(16, 102);
            this.lblClipboardPopupPosition.Name = "lblClipboardPopupPosition";
            this.lblClipboardPopupPosition.Size = new System.Drawing.Size(213, 18);
            this.lblClipboardPopupPosition.TabIndex = 15;
            this.lblClipboardPopupPosition.Text = "Clipboard Popup position";
            // 
            // btnPositionTemp
            // 
            this.btnPositionTemp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPositionTemp.Location = new System.Drawing.Point(256, 57);
            this.btnPositionTemp.Name = "btnPositionTemp";
            this.btnPositionTemp.Size = new System.Drawing.Size(107, 28);
            this.btnPositionTemp.TabIndex = 14;
            this.btnPositionTemp.Text = "Position";
            this.btnPositionTemp.UseVisualStyleBackColor = true;
            // 
            // rbSaveImagesToClips
            // 
            this.rbSaveImagesToClips.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbSaveImagesToClips.Location = new System.Drawing.Point(312, 163);
            this.rbSaveImagesToClips.Name = "rbSaveImagesToClips";
            this.rbSaveImagesToClips.Size = new System.Drawing.Size(18, 23);
            this.rbSaveImagesToClips.TabIndex = 13;
            this.rbSaveImagesToClips.TabStop = true;
            this.rbSaveImagesToClips.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Save Images to clips";
            // 
            // lblPopupWindows
            // 
            this.lblPopupWindows.AutoSize = true;
            this.lblPopupWindows.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPopupWindows.Location = new System.Drawing.Point(14, 21);
            this.lblPopupWindows.Name = "lblPopupWindows";
            this.lblPopupWindows.Size = new System.Drawing.Size(87, 25);
            this.lblPopupWindows.TabIndex = 10;
            this.lblPopupWindows.Text = "Popups";
            // 
            // lblTemplatesPopupPosition
            // 
            this.lblTemplatesPopupPosition.AutoSize = true;
            this.lblTemplatesPopupPosition.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemplatesPopupPosition.Location = new System.Drawing.Point(16, 62);
            this.lblTemplatesPopupPosition.Name = "lblTemplatesPopupPosition";
            this.lblTemplatesPopupPosition.Size = new System.Drawing.Size(220, 18);
            this.lblTemplatesPopupPosition.TabIndex = 9;
            this.lblTemplatesPopupPosition.Text = "Templates Popup position";
            // 
            // btnSetAllDefaults
            // 
            this.btnSetAllDefaults.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetAllDefaults.Location = new System.Drawing.Point(18, 79);
            this.btnSetAllDefaults.Name = "btnSetAllDefaults";
            this.btnSetAllDefaults.Size = new System.Drawing.Size(211, 31);
            this.btnSetAllDefaults.TabIndex = 12;
            this.btnSetAllDefaults.Text = "Set All to defaults";
            this.btnSetAllDefaults.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(18, 797);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 20);
            this.panel1.TabIndex = 13;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSetAllDefaults);
            this.Controls.Add(this.pnlPopups);
            this.Controls.Add(this.pnlHotkeys);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.lblSettings);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(815, 833);
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            this.pnlHotkeys.ResumeLayout(false);
            this.pnlHotkeys.PerformLayout();
            this.pnlPopups.ResumeLayout(false);
            this.pnlPopups.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Label lblStartOnSystem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblStartWithEditor;
        private System.Windows.Forms.RadioButton rbStartWithSystem;
        private System.Windows.Forms.Panel pnlHotkeys;
        private System.Windows.Forms.Label lblOpenClipboardPopup;
        private System.Windows.Forms.Label lblHotkeys;
        private System.Windows.Forms.Label lblOpenTemplatePopup;
        private System.Windows.Forms.TextBox tbHotkeyMainEditor;
        private System.Windows.Forms.TextBox tbHotkeyClipboard;
        private System.Windows.Forms.TextBox tbHotkeyTemplates;
        private System.Windows.Forms.Label lblOpenEditor;
        private System.Windows.Forms.Panel pnlPopups;
        private System.Windows.Forms.RadioButton rbSaveImagesToClips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPopupWindows;
        private System.Windows.Forms.Label lblTemplatesPopupPosition;
        private System.Windows.Forms.Button btnSetAllDefaults;
        private System.Windows.Forms.Button btnPositionTemp;
        private System.Windows.Forms.Label lblClipboardPopupPosition;
        private System.Windows.Forms.Button btnPositionClip;
        private System.Windows.Forms.RadioButton rbShowVersionsOnHover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbShowTemplateTextOnHover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditOpenMainEditor;
        private System.Windows.Forms.Button btnEditOpenClipboardPopup;
        private System.Windows.Forms.Button btnEditOpenTemplatesPopup;
        private System.Windows.Forms.Panel panel1;
    }
}
