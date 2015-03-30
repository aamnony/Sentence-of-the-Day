namespace Quote_of_the_Day
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblMain = new System.Windows.Forms.LinkLabel();
            this.contextMenuQuote = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinUnpinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuAuthor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoIsThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSecondary = new System.Windows.Forms.Label();
            this.picQuote = new System.Windows.Forms.PictureBox();
            this.sendToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuQuote.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.contextMenuAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuote)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.ContextMenuStrip = this.contextMenuQuote;
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMain.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMain.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblMain.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblMain.LinkColor = System.Drawing.Color.Black;
            this.lblMain.Location = new System.Drawing.Point(0, 40);
            this.lblMain.MinimumSize = new System.Drawing.Size(384, 170);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(545, 200);
            this.lblMain.TabIndex = 0;
            this.lblMain.TabStop = true;
            this.lblMain.Text = "linkLabel1";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMain_LinkClicked);
            this.lblMain.Click += new System.EventHandler(this.notForm_Click);
            // 
            // contextMenuQuote
            // 
            this.contextMenuQuote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.copyAllToolStripMenuItem,
            this.openLinkToolStripMenuItem,
            this.sendToToolStripMenuItem});
            this.contextMenuQuote.Name = "contextMenuQuote";
            this.contextMenuQuote.Size = new System.Drawing.Size(153, 114);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyAllToolStripMenuItem.Text = "Copy All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // openLinkToolStripMenuItem
            // 
            this.openLinkToolStripMenuItem.Name = "openLinkToolStripMenuItem";
            this.openLinkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openLinkToolStripMenuItem.Text = "Open Link";
            this.openLinkToolStripMenuItem.Click += new System.EventHandler(this.openLinkToolStripMenuItem_Click);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.pinUnpinToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.ShowItemToolTips = true;
            this.menuMain.Size = new System.Drawing.Size(545, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // pinUnpinToolStripMenuItem
            // 
            this.pinUnpinToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pinUnpinToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pinUnpinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pinUnpinToolStripMenuItem.Image")));
            this.pinUnpinToolStripMenuItem.Name = "pinUnpinToolStripMenuItem";
            this.pinUnpinToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.pinUnpinToolStripMenuItem.Text = "PinMenu";
            this.pinUnpinToolStripMenuItem.ToolTipText = "Pin";
            this.pinUnpinToolStripMenuItem.CheckedChanged += new System.EventHandler(this.pinUnpinToolStripMenuItem_CheckedChanged);
            this.pinUnpinToolStripMenuItem.Click += new System.EventHandler(this.pinUnpinToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuAuthor
            // 
            this.contextMenuAuthor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAuthorToolStripMenuItem,
            this.whoIsThisToolStripMenuItem});
            this.contextMenuAuthor.Name = "contextMenuQuote";
            this.contextMenuAuthor.Size = new System.Drawing.Size(143, 48);
            // 
            // copyAuthorToolStripMenuItem
            // 
            this.copyAuthorToolStripMenuItem.Name = "copyAuthorToolStripMenuItem";
            this.copyAuthorToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.copyAuthorToolStripMenuItem.Text = "Copy Author";
            this.copyAuthorToolStripMenuItem.Click += new System.EventHandler(this.copyAuthorToolStripMenuItem_Click);
            // 
            // whoIsThisToolStripMenuItem
            // 
            this.whoIsThisToolStripMenuItem.Name = "whoIsThisToolStripMenuItem";
            this.whoIsThisToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.whoIsThisToolStripMenuItem.Text = "Who is This?";
            this.whoIsThisToolStripMenuItem.Click += new System.EventHandler(this.whoIsThisToolStripMenuItem_Click);
            // 
            // lblSecondary
            // 
            this.lblSecondary.ContextMenuStrip = this.contextMenuAuthor;
            this.lblSecondary.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblSecondary.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSecondary.Image = global::Quote_of_the_Day.Properties.Resources.quotes;
            this.lblSecondary.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSecondary.Location = new System.Drawing.Point(0, 240);
            this.lblSecondary.MinimumSize = new System.Drawing.Size(384, 50);
            this.lblSecondary.Name = "lblSecondary";
            this.lblSecondary.Size = new System.Drawing.Size(545, 50);
            this.lblSecondary.TabIndex = 2;
            this.lblSecondary.Text = "label1";
            this.lblSecondary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSecondary.Click += new System.EventHandler(this.lblSecondary_Click);
            // 
            // picQuote
            // 
            this.picQuote.Dock = System.Windows.Forms.DockStyle.Top;
            this.picQuote.Image = global::Quote_of_the_Day.Properties.Resources.quotes;
            this.picQuote.Location = new System.Drawing.Point(0, 0);
            this.picQuote.Name = "picQuote";
            this.picQuote.Size = new System.Drawing.Size(545, 40);
            this.picQuote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picQuote.TabIndex = 3;
            this.picQuote.TabStop = false;
            this.picQuote.Click += new System.EventHandler(this.notForm_Click);
            // 
            // sendToToolStripMenuItem
            // 
            this.sendToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailToolStripMenuItem});
            this.sendToToolStripMenuItem.Name = "sendToToolStripMenuItem";
            this.sendToToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sendToToolStripMenuItem.Text = "Send to";
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mailToolStripMenuItem.Text = "Mail recipient";
            this.mailToolStripMenuItem.Click += new System.EventHandler(this.mailToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 391);
            this.Controls.Add(this.lblSecondary);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.picQuote);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 270);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quote of the Day";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.contextMenuQuote.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.contextMenuAuthor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQuote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblMain;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblSecondary;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.PictureBox picQuote;
        private System.Windows.Forms.ContextMenuStrip contextMenuQuote;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinUnpinToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuAuthor;
        private System.Windows.Forms.ToolStripMenuItem copyAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoIsThisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;

    }
}

