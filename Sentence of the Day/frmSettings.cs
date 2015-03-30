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
    public partial class frmSettings : Form
    {
        public const string MAIN_FONT = "MainFont";
        public const string SECONDARY_FONT = "SecondaryFont";
        public const string MAIN_FONT_COLOR = "MainFontColor";
        public const string SECONDARY_FONT_COLOR = "SecondaryFontColor";

        // Original settings
        Font oMainFont;
        Font oSecondaryFont;
        Color oMainColor;
        Color oSecondaryColor;
        
        public static bool SaveSetting(string settingName, object value)
        {
            try
            {
                Properties.Settings.Default[settingName] = value;

            }
            catch (Exception)
            {
                // Not a setting
                return false;
            }
            return true;
        }

//----------------------------------------------------------------------------------------------------------

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            oMainFont = Properties.Settings.Default.MainFont;
            oMainColor = Properties.Settings.Default.MainFontColor;
            oSecondaryFont = Properties.Settings.Default.SecondaryFont;
            oSecondaryColor = Properties.Settings.Default.SecondaryFontColor;

            // Only 1 site for now...
            string appVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            cmbSites.Enabled = false;
            ToolTip tempToolTip = new ToolTip();
            tempToolTip.AutoPopDelay = 5000;
            tempToolTip.InitialDelay = 1000;
            tempToolTip.ReshowDelay = 500;
            tempToolTip.ShowAlways = true;
            tempToolTip.SetToolTip(lblSite, "Only a single site is available in this version (" + appVersion +')');
            //

            cmbSites.SelectedIndex = 0;
            lblExampleMain.Font = Properties.Settings.Default.MainFont;
            lblExampleMain.ForeColor = Properties.Settings.Default.MainFontColor;

            lblExampleSecondary.Font = Properties.Settings.Default.SecondaryFont;
            lblExampleSecondary.ForeColor = Properties.Settings.Default.SecondaryFontColor;
        }

        private void btnChangeMainFont_Click(object sender, EventArgs e)
        {
            fontDialogMain.Font = lblExampleMain.Font;
            fontDialogMain.Color = lblExampleMain.ForeColor;

            fontDialogMain.ShowDialog(this);

            lblExampleMain.Font = fontDialogMain.Font;
            lblExampleMain.ForeColor = fontDialogMain.Color;
        }

        private void btnChangeSecondaryFont_Click(object sender, EventArgs e)
        {
            fontDialogSecondary.Font = lblExampleSecondary.Font;
            fontDialogSecondary.Color = lblExampleSecondary.ForeColor;
            
            fontDialogSecondary.ShowDialog(this);

            lblExampleSecondary.Font= fontDialogSecondary.Font;
            lblExampleSecondary.ForeColor = fontDialogSecondary.Color;

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            saveAll();
            ((frmMain)this.Owner).loadSettings();
        }


        void showSavingErrorMessege(string setting)
        {
            string error = "Error! " + setting + " setting has not been saved! Please contact system administrator";
            MessageBox.Show(this, error);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            saveAll();
            ((frmMain)this.Owner).loadSettings();
            this.Close();
        }

        private void saveAll()
        {
            if (!SaveSetting(MAIN_FONT, lblExampleMain.Font))
            {
                showSavingErrorMessege(MAIN_FONT);
            }

            if (!SaveSetting(SECONDARY_FONT, lblExampleSecondary.Font))
            {
                showSavingErrorMessege(SECONDARY_FONT);
            }

            if (!SaveSetting(MAIN_FONT_COLOR, lblExampleMain.ForeColor))
            {
                showSavingErrorMessege(MAIN_FONT_COLOR);
            }

            if (!SaveSetting(SECONDARY_FONT_COLOR, lblExampleSecondary.ForeColor))
            {
                showSavingErrorMessege(SECONDARY_FONT_COLOR);
            }
            Properties.Settings.Default.Save();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default[MAIN_FONT] = oMainFont;
            Properties.Settings.Default[MAIN_FONT_COLOR] = oMainColor;
            Properties.Settings.Default[SECONDARY_FONT] = oSecondaryFont;
            Properties.Settings.Default[SECONDARY_FONT_COLOR] = oSecondaryColor;

            Properties.Settings.Default.Save();

            ((frmMain)this.Owner).loadSettings();

            this.Close();
        }
    }
}
