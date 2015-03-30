using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quote_of_the_Day
{
    public partial class frmMain : Form
    {
        public const string SEARCH_ENGINE = "https://www.google.co.il/search?q=";
        const int MENU_TOGGLE_KEY = 18;

        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings();
            settings.Show(this);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
            aboutToolStripMenuItem.Text += " " + this.Text;
            loadSettings();
            menuMain.Visible = pinUnpinToolStripMenuItem.Checked = Properties.Settings.Default.PinMenu;

            // if (site == quotes)

            generateQuote();
        }

        private void generateQuote()
        {
            Cursor originalCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            Quote quote = new Quote();
            lblMain.Text = quote.getQuote();
            lblSecondary.Text = quote.getAuthor();
            lblMain.Tag = quote.getUrl();
            lblMain.LinkVisited = false;

            // Resize form

            int width = max(this.MinimumSize.Width, Properties.Settings.Default.FormWidth);
            this.MinimumSize = new Size(this.MinimumSize.Width, lblMain.Height + lblSecondary.Height + 50 + menuMain.Height + picQuote.Height);
            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Size.Width, this.MinimumSize.Height);
            this.Size = new Size(width, this.MinimumSize.Height);
            

            this.Cursor = originalCursor;
            // DEBUG
            //this.Text = quote.getUrl();
        }

        private int max(int p1, int p2)
        {
            return p1>p2 ? p1 : p2;
        }

        public void loadSettings()
        {
            lblMain.Font = Properties.Settings.Default.MainFont;
            lblMain.LinkColor = Properties.Settings.Default.MainFontColor;
            lblSecondary.Font = Properties.Settings.Default.SecondaryFont;
            lblSecondary.ForeColor = Properties.Settings.Default.SecondaryFontColor;
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue==MENU_TOGGLE_KEY) && (!pinUnpinToolStripMenuItem.Checked))
            {
                menuMain.Visible = !menuMain.Visible;
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateQuote();
        }

        private void lblMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                openLinkToolStripMenuItem_Click(null, null);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblMain.Text,TextDataFormat.Text);
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblMain.Text + " " + lblSecondary.Text, TextDataFormat.Text);
        }

        private void openLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lblMain.Tag.ToString());
            lblMain.LinkVisited = true;
        }

        private void copyAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Skip '-' at start of author
            Clipboard.SetText(lblSecondary.Text.Substring(1), TextDataFormat.Text);
        }

        private void whoIsThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Skip '-' at start of author
            System.Diagnostics.Process.Start(SEARCH_ENGINE + lblSecondary.Text.Substring(1));
        }


        private void pinUnpinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pinUnpinToolStripMenuItem.Checked = !pinUnpinToolStripMenuItem.Checked;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Properties.Settings.Default[pinUnpinToolStripMenuItem.Text] = pinUnpinToolStripMenuItem.Checked;
            Properties.Settings.Default["FormWidth"] = this.Width;
            Properties.Settings.Default.Save();

            base.OnClosing(e);
        }

        private void pinUnpinToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (pinUnpinToolStripMenuItem.Checked)
            {
                pinUnpinToolStripMenuItem.Image = Properties.Resources.unpin;
                pinUnpinToolStripMenuItem.ToolTipText = "Unpin";
            }
            else
            {
                pinUnpinToolStripMenuItem.Image = Properties.Resources.pin;
                pinUnpinToolStripMenuItem.ToolTipText = "Pin";
            }
        }

        private void notForm_Click(object sender, EventArgs e)
        {
            menuMain.Visible = pinUnpinToolStripMenuItem.Checked;
        }

        private void lblSecondary_Click(object sender, EventArgs e)
        {
            notForm_Click(sender, e);

            // Search author
            whoIsThisToolStripMenuItem_Click(null, null);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        private void mailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder mail = new StringBuilder("mailto:?subject=");
            mail.Append("A Famous Quote by ").Append(lblSecondary.Text.Substring(1));
            mail.Append("&body=").Append(lblMain.Text).Append(' ').Append(lblSecondary.Text);

            System.Diagnostics.Process.Start(mail.ToString());
        }
    }
}
