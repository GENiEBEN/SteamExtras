using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GameSearchDeskBand
{
    public partial class DeskBandUI : UserControl
    {
        public DeskBandUI()
        {
            InitializeComponent();
            rightClick.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
        }

        private void buttonGo_Click_1(object sender, EventArgs e)
        {
            if (menuSteam.Checked == true)
            {
                Process.Start("https://store.steampowered.com/search/?term=" + textBoxSearch.Text);
            }
            if (menuEGS.Checked == true)
            {
                Process.Start("https://www.epicgames.com/store/en-US/browse?q=" + textBoxSearch.Text);
            }
            if (menuGOG.Checked == true)
            {
                Process.Start("https://www.gog.com/games?search=" + textBoxSearch.Text);
            }
            if (menuOrigin.Checked == true)
            {
                Process.Start("https://www.origin.com/search?searchString=" + textBoxSearch.Text);
            }
            if (menuITD.Checked == true)
            {
                Process.Start("https://isthereanydeal.com/search/?q=" + textBoxSearch.Text);
            }
            if (menuCME.Checked == true)
            {
                Process.Start("https://completionist.me/search?q=" + textBoxSearch.Text);
            }
            if (menuSH.Checked == true)
            {
                if (menuSHgames.Checked == true)
                {
                    Process.Start("https://steamhunters.com/games?q=" + textBoxSearch.Text);
                }
                if (menuSHachs.Checked == true)
                {
                    Process.Start("https://steamhunters.com/achievements?q=" + textBoxSearch.Text);
                }
                if (menuSHprofiles.Checked == true)
                {
                    Process.Start("https://steamhunters.com/profiles?q=" + textBoxSearch.Text);
                }
            }
            if (menuEXO.Checked == true)
            {
                Process.Start("https://www.exophase.com/search?s=" + textBoxSearch.Text);
            }

        }
    }

    public class TestColorTable : ProfessionalColorTable
    {
        Color Colour1 = Color.FromArgb(20, 20, 20);

        public override Color MenuItemBorder
        {
            get { return Colour1; }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return Colour1; }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return Colour1; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Colour1; }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Colour1; }
        }

        public override Color MenuItemSelected
        {
            get { return Color.Green; }
        }

        public override Color MenuBorder  //added for changing the menu border
        {
            get { return Colour1; }
        }

    }
}

