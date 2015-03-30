namespace Quote_of_the_Day
{
    partial class frmSettings
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
            this.btnChangeMainFont = new System.Windows.Forms.Button();
            this.grpFonts = new System.Windows.Forms.GroupBox();
            this.lblExampleSecondary = new System.Windows.Forms.Label();
            this.lblExampleMain = new System.Windows.Forms.Label();
            this.lblSecondaryFont = new System.Windows.Forms.Label();
            this.lblMainFont = new System.Windows.Forms.Label();
            this.btnChangeSecondaryFont = new System.Windows.Forms.Button();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.cmbSites = new System.Windows.Forms.ComboBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.fontDialogMain = new System.Windows.Forms.FontDialog();
            this.fontDialogSecondary = new System.Windows.Forms.FontDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpFonts.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeMainFont
            // 
            this.btnChangeMainFont.AutoSize = true;
            this.btnChangeMainFont.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMainFont.Location = new System.Drawing.Point(97, 25);
            this.btnChangeMainFont.Name = "btnChangeMainFont";
            this.btnChangeMainFont.Size = new System.Drawing.Size(26, 23);
            this.btnChangeMainFont.TabIndex = 0;
            this.btnChangeMainFont.Text = "...";
            this.btnChangeMainFont.UseVisualStyleBackColor = true;
            this.btnChangeMainFont.Click += new System.EventHandler(this.btnChangeMainFont_Click);
            // 
            // grpFonts
            // 
            this.grpFonts.Controls.Add(this.lblExampleSecondary);
            this.grpFonts.Controls.Add(this.lblExampleMain);
            this.grpFonts.Controls.Add(this.lblSecondaryFont);
            this.grpFonts.Controls.Add(this.lblMainFont);
            this.grpFonts.Controls.Add(this.btnChangeSecondaryFont);
            this.grpFonts.Controls.Add(this.btnChangeMainFont);
            this.grpFonts.Location = new System.Drawing.Point(12, 82);
            this.grpFonts.Name = "grpFonts";
            this.grpFonts.Size = new System.Drawing.Size(391, 112);
            this.grpFonts.TabIndex = 1;
            this.grpFonts.TabStop = false;
            this.grpFonts.Text = "Fonts";
            // 
            // lblExampleSecondary
            // 
            this.lblExampleSecondary.AutoSize = true;
            this.lblExampleSecondary.Location = new System.Drawing.Point(220, 64);
            this.lblExampleSecondary.Name = "lblExampleSecondary";
            this.lblExampleSecondary.Size = new System.Drawing.Size(38, 13);
            this.lblExampleSecondary.TabIndex = 12;
            this.lblExampleSecondary.Text = "Author";
            // 
            // lblExampleMain
            // 
            this.lblExampleMain.AutoSize = true;
            this.lblExampleMain.Location = new System.Drawing.Point(220, 25);
            this.lblExampleMain.Name = "lblExampleMain";
            this.lblExampleMain.Size = new System.Drawing.Size(36, 13);
            this.lblExampleMain.TabIndex = 10;
            this.lblExampleMain.Text = "Quote";
            // 
            // lblSecondaryFont
            // 
            this.lblSecondaryFont.AutoSize = true;
            this.lblSecondaryFont.Location = new System.Drawing.Point(6, 64);
            this.lblSecondaryFont.Name = "lblSecondaryFont";
            this.lblSecondaryFont.Size = new System.Drawing.Size(85, 13);
            this.lblSecondaryFont.TabIndex = 11;
            this.lblSecondaryFont.Text = "Secondary Font:";
            // 
            // lblMainFont
            // 
            this.lblMainFont.AutoSize = true;
            this.lblMainFont.Location = new System.Drawing.Point(6, 29);
            this.lblMainFont.Name = "lblMainFont";
            this.lblMainFont.Size = new System.Drawing.Size(57, 13);
            this.lblMainFont.TabIndex = 10;
            this.lblMainFont.Text = "Main Font:";
            // 
            // btnChangeSecondaryFont
            // 
            this.btnChangeSecondaryFont.AutoSize = true;
            this.btnChangeSecondaryFont.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSecondaryFont.Location = new System.Drawing.Point(97, 60);
            this.btnChangeSecondaryFont.Name = "btnChangeSecondaryFont";
            this.btnChangeSecondaryFont.Size = new System.Drawing.Size(26, 23);
            this.btnChangeSecondaryFont.TabIndex = 5;
            this.btnChangeSecondaryFont.Text = "...";
            this.btnChangeSecondaryFont.UseVisualStyleBackColor = true;
            this.btnChangeSecondaryFont.Click += new System.EventHandler(this.btnChangeSecondaryFont_Click);
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.cmbSites);
            this.grpGeneral.Controls.Add(this.lblSite);
            this.grpGeneral.Location = new System.Drawing.Point(12, 12);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(391, 64);
            this.grpGeneral.TabIndex = 2;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // cmbSites
            // 
            this.cmbSites.FormattingEnabled = true;
            this.cmbSites.Items.AddRange(new object[] {
            "http://www.quotationspage.com/"});
            this.cmbSites.Location = new System.Drawing.Point(40, 27);
            this.cmbSites.Name = "cmbSites";
            this.cmbSites.Size = new System.Drawing.Size(345, 21);
            this.cmbSites.TabIndex = 12;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(6, 30);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(28, 13);
            this.lblSite.TabIndex = 11;
            this.lblSite.Text = "Site:";
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnApply.Location = new System.Drawing.Point(86, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 25);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // fontDialogMain
            // 
            this.fontDialogMain.MaxSize = 24;
            this.fontDialogMain.MinSize = 6;
            this.fontDialogMain.ShowColor = true;
            // 
            // fontDialogSecondary
            // 
            this.fontDialogSecondary.MaxSize = 24;
            this.fontDialogSecondary.MinSize = 6;
            this.fontDialogSecondary.ShowColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(167, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Location = new System.Drawing.Point(149, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 36);
            this.panel1.TabIndex = 9;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 241);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.grpFonts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.grpFonts.ResumeLayout(false);
            this.grpFonts.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeMainFont;
        private System.Windows.Forms.GroupBox grpFonts;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Button btnChangeSecondaryFont;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.FontDialog fontDialogMain;
        private System.Windows.Forms.FontDialog fontDialogSecondary;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblSecondaryFont;
        private System.Windows.Forms.Label lblMainFont;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExampleSecondary;
        private System.Windows.Forms.Label lblExampleMain;
        private System.Windows.Forms.ComboBox cmbSites;
        private System.Windows.Forms.Label lblSite;

    }
}