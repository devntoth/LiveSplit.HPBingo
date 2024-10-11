using System;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.UI;

namespace LiveSplit.HPBingo.Components.Settings
{
    public partial class HPBingoSettings : UserControl
    {
        public HPBingoSettings()
        {
            InitializeComponent();
        }

        public int ComponentWidth { get; set; } = BingoConstants.DEFAULT_WIDTH;
        public int ComponentHeight { get; set; } = BingoConstants.DEFAULT_HEIGHT;
        public LayoutMode LayoutMode { get; set; } = LayoutMode.Vertical;

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        public XmlNode GetSettings(XmlDocument xml)
        {
            XmlElement settings = xml.CreateElement("Settings");
            CreateSettingsNode(xml, settings);   

            return settings;
        }

        public void SetSettings(XmlNode settings)
        {
            ComponentWidth = SettingsHelper.ParseInt(settings[nameof(ComponentWidth)], BingoConstants.DEFAULT_WIDTH);
            ComponentHeight = SettingsHelper.ParseInt(settings[nameof(ComponentHeight)], BingoConstants.DEFAULT_HEIGHT);
            LayoutMode = SettingsHelper.ParseEnum(settings[nameof(LayoutMode)], LayoutMode.Vertical);
        }

        private int CreateSettingsNode(XmlDocument xml, XmlElement node)
        {
            return SettingsHelper.CreateSetting(xml, node, "Version", "1.0") ^
                SettingsHelper.CreateSetting(xml, node, nameof(ComponentWidth), ComponentWidth) ^
                SettingsHelper.CreateSetting(xml, node, nameof(ComponentHeight), ComponentHeight) ^
                SettingsHelper.CreateSetting(xml, node, nameof(LayoutMode), LayoutMode);
        }

        private void BingoSettingsLoaded(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
    }
}
