using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.UI;

namespace LiveSplit.HPBingo.Components.Settings
{
    public partial class HPBingoSettings : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public HPBingoSettings()
        {
            InitializeComponent();
            SetupBindings();

            ComponentWidth = BingoConstants.DEFAULT_WIDTH;
            ComponentHeight = BingoConstants.DEFAULT_HEIGHT;
            UseLayoutFontSize = true;
            UseTextFontForCounters = false;
            FontSize = BingoConstants.DEFAULT_FONTSIZE;
            UseLayoutTextColor = true;
            UseTextColorForCounters = true;
            TextColor = BingoConstants.DEFAULT_TEXTCOLOR;
            CounterColor = BingoConstants.DEFAULT_COUNTERCOLOR;
        }

        private void SetupBindings()
        {
            string selectorValueName = nameof(NumericUpDown.Value);
            string checkedName = nameof(CheckBox.Checked);

            widthSelector.DataBindings.Add(selectorValueName, this, nameof(ComponentWidth), false, DataSourceUpdateMode.OnPropertyChanged);
            heightSelector.DataBindings.Add(selectorValueName, this, nameof(ComponentHeight), false, DataSourceUpdateMode.OnPropertyChanged);
            fontSizeSelector.DataBindings.Add(selectorValueName, this, nameof(FontSize), false, DataSourceUpdateMode.OnPropertyChanged);

            useLayoutFont.DataBindings.Add(checkedName, this, nameof(UseLayoutFontSize), false, DataSourceUpdateMode.OnPropertyChanged);
            useTextFont.DataBindings.Add(checkedName, this, nameof(UseTextFontForCounters), false, DataSourceUpdateMode.OnPropertyChanged);
            useLayoutColor.DataBindings.Add(checkedName, this, nameof(UseLayoutTextColor), false,  DataSourceUpdateMode.OnPropertyChanged);
            useTextColor.DataBindings.Add(checkedName, this, nameof(UseTextColorForCounters), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BingoSettingsLoaded(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private int _componentWidth;
        public int ComponentWidth 
        {
            get => _componentWidth;
            set => SetValue(ref _componentWidth, value);
        }

        private int _componentHeight;
        public int ComponentHeight 
        {
            get => _componentHeight;
            set => SetValue(ref _componentHeight, value);
        }

        public LayoutMode LayoutMode { get; set; } = LayoutMode.Vertical;

        private bool _useLayoutFontSize;
        public bool UseLayoutFontSize
        {
            get => _useLayoutFontSize;
            set
            {
                if (SetValue(ref _useLayoutFontSize, value))
                    fontSizeSelector.Enabled = !value;
            }
        }

        private int _fontSize;
        public int FontSize
        {
            get => _fontSize;
            set => SetValue(ref _fontSize, value);
        }

        private bool _useTextFontForCounters;
        public bool UseTextFontForCounters
        {
            get => _useTextFontForCounters;
            set => SetValue(ref _useTextFontForCounters, value);
        }

        private bool _useLayoutTextColor;
        public bool UseLayoutTextColor
        {
            get => _useLayoutTextColor;
            set
            {
                if (SetValue(ref _useLayoutTextColor, value))
                    textColorPicker.Enabled = !value;
            }
        }

        private bool _useTextColorForCounters;
        public bool UseTextColorForCounters
        {
            get => _useTextColorForCounters;
            set
            {
                if (SetValue(ref _useTextColorForCounters, value))
                    counterColorPicker.Enabled = !value;
            }
        }

        private Color _textColor;
        public Color TextColor
        {
            get => _textColor;
            set 
            { 
                if (SetValue(ref _textColor, value))
                    textColorPicker.BackColor = value;
            }
        }

        private Color _counterColor;
        public Color CounterColor
        {
            get => _counterColor;
            set 
            { 
                if (SetValue(ref _counterColor, value))
                    counterColorPicker.BackColor = value;
            }
        }

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
            UseLayoutFontSize = SettingsHelper.ParseBool(settings[nameof(UseLayoutFontSize)], true);
            FontSize = SettingsHelper.ParseInt(settings[nameof(FontSize)], BingoConstants.DEFAULT_FONTSIZE);
            UseTextFontForCounters = SettingsHelper.ParseBool(settings[nameof(UseTextFontForCounters)], false);
            UseLayoutTextColor = SettingsHelper.ParseBool(settings[nameof(UseLayoutTextColor)], true);
            UseTextColorForCounters = SettingsHelper.ParseBool(settings[nameof(UseTextColorForCounters)], true);
            TextColor = SettingsHelper.ParseColor(settings[nameof(TextColor)], BingoConstants.DEFAULT_TEXTCOLOR);
            CounterColor = SettingsHelper.ParseColor(settings[nameof(CounterColor)], BingoConstants.DEFAULT_COUNTERCOLOR);
        }

        private int CreateSettingsNode(XmlDocument xml, XmlElement node)
        {
            return SettingsHelper.CreateSetting(xml, node, "Version", "1.0") ^
                SettingsHelper.CreateSetting(xml, node, nameof(ComponentWidth), ComponentWidth) ^
                SettingsHelper.CreateSetting(xml, node, nameof(ComponentHeight), ComponentHeight) ^
                SettingsHelper.CreateSetting(xml, node, nameof(LayoutMode), LayoutMode) ^
                SettingsHelper.CreateSetting(xml, node, nameof(UseLayoutFontSize), UseLayoutFontSize) ^
                SettingsHelper.CreateSetting(xml, node, nameof(FontSize), FontSize) ^
                SettingsHelper.CreateSetting(xml, node, nameof(UseTextFontForCounters), UseTextFontForCounters) ^
                SettingsHelper.CreateSetting(xml, node, nameof(UseLayoutTextColor), UseLayoutTextColor) ^
                SettingsHelper.CreateSetting(xml, node, nameof(UseTextColorForCounters), UseTextColorForCounters) ^
                SettingsHelper.CreateSetting(xml, node, nameof(TextColor), TextColor) ^
                SettingsHelper.CreateSetting(xml, node, nameof(CounterColor), CounterColor);
        }

        private bool SetValue<T>(ref T oldValue, T newValue, [CallerMemberName] string property = null)
        {
            if (EqualityComparer<T>.Default.Equals(oldValue, newValue)) 
                return false;

            oldValue = newValue;
            RaisePropertyChanged(property);
            return true;
        }

        private void RaisePropertyChanged(params string[] properties)
        {
            if (properties is null || properties.Length == 0)
                return;

            foreach (var property in properties)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }

        private void TextColorClick(object sender, EventArgs e)
        {
            colorPicker.Color = TextColor;
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                TextColor = colorPicker.Color;
            }
        }

        private void CounterColorClick(object sender, EventArgs e)
        {
            colorPicker.Color = CounterColor;
            if (colorPicker.ShowDialog(this) == DialogResult.OK)
            {
                CounterColor = colorPicker.Color;
            }
        }
    }
}
