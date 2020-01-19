using SharpShell.Attributes;
using SharpShell.SharpDeskBand;
using System.Runtime.InteropServices;

namespace GameSearchDeskBand
{
    [ComVisible(true)]
    [DisplayName("Game Search")]
    public class GameSearchDeskBand : SharpDeskBand
    {
        protected override System.Windows.Forms.UserControl CreateDeskBand()
        {
            return new DeskBandUI();
        }

        protected override BandOptions GetBandOptions()
        {
            return new BandOptions
                   {
                       HasVariableHeight = false,
                       IsSunken = false,
                       ShowTitle = true,
                       Title = "Game Search",
                       UseBackgroundColour = false,
                       AlwaysShowGripper = false,
                       HasNoMargins=true
                   };
        }
   }
}
