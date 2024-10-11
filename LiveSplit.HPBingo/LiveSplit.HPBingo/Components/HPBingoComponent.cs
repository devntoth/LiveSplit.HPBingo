using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.HPBingo.Components.Settings;
using LiveSplit.HPBingo.Forms;
using LiveSplit.Model;
using LiveSplit.Options;
using LiveSplit.UI;
using LiveSplit.UI.Components;

namespace LiveSplit.HPBingo.Components
{
    public class HPBingoComponent : ControlComponent
    {
        private readonly LiveSplitState _state;
        private readonly HPBingoSettings _settings;
        private readonly HPBingoHostControl _hostControl;

        public HPBingoComponent(LiveSplitState state)
            : this(state, new HPBingoHostControl())
        {
        }

        private HPBingoComponent(LiveSplitState state, HPBingoHostControl control)
            : base(state, control, ex => HandleException(state.Form, ex))
        {
            _state = state;
            _hostControl = control;
            _settings = new HPBingoSettings();

            state.OnReset += OnResetState;
        }

        private static void HandleException(Form form, Exception ex)
        {
            MessageBox.Show(form, $"Unexpected error occurred:{Environment.NewLine}{ex.Message}{Environment.NewLine}Here: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnResetState(object sender, TimerPhase value)
        {
            InvokeIfNeeded(_hostControl.ResetCounters);
        }

        public override string ComponentName => BingoConstants.COMPONENT_NAME;

        public override float HorizontalWidth => _settings.ComponentWidth;

        public override float VerticalHeight => _settings.ComponentHeight;

        public override float MinimumHeight => BingoConstants.MIN_HEIGHT;

        public override float MinimumWidth => BingoConstants.MIN_WIDTH;

        public override Control GetSettingsControl(LayoutMode mode)
        {
            _settings.LayoutMode = mode;
            return _settings;
        }

        public int GetSettingsHashCode()
        {
            return _settings.GetSettingsHashCode();
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return _settings.GetSettings(document);
        }

        public override void SetSettings(XmlNode settings)
        {
            _settings.SetSettings(settings);
        }

        public override void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            base.DrawHorizontal(g, state, height, clipRegion);
        }

        public override void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            base.DrawVertical(g, state, width, clipRegion);
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (_hostControl.IsDisposed)
                return;

            UpdateStyle(state.LayoutSettings);
            base.Update(invalidator, state, width, height, mode);
        }

        public override void Dispose()
        {
            _state.OnReset -= OnResetState;

            base.Dispose();
        }

        private void UpdateStyle(Options.LayoutSettings layout)
        {
            InvokeIfNeeded(() =>
            {
                _hostControl.LabelColor = layout.TextColor;
                _hostControl.LabelFont = layout.TextFont;
                _hostControl.CounterColor = layout.AheadGainingTimeColor;
                _hostControl.CounterFont = layout.TimerFont;
            });
        }
    }
}
