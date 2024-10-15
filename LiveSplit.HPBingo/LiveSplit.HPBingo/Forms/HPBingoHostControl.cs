using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiveSplit.HPBingo.Types;
using LiveSplit.UI.Components;

namespace LiveSplit.HPBingo.Forms
{
    public partial class HPBingoHostControl : UserControl
    {
        private readonly Dictionary<BingoGoal, HPBingoScoreTracker> _scores;

        public HPBingoHostControl()
        {
            InitializeComponent();
            
            _scores = counterTable.Controls.OfType<HPBingoScoreTracker>().ToDictionary(x => x.GoalType);
        }

        private Color _labelColor;
        public Color LabelColor
        {
            get => _labelColor;
            set => SetValue(ref _labelColor, value, (st, val) => st.LabelColor = val);
        }

        private Color _counterColor;
        public Color CounterColor
        {
            get => _counterColor;
            set => SetValue(ref _counterColor, value, (st, val) => st.CounterColor = val);
        }

        private Font _labelFont;
        public Font LabelFont
        {
            get => _labelFont;
            set => SetValue(ref _labelFont, value, (st, val) => st.LabelFont = val);
        }

        private Font _counterFont;
        public Font CounterFont
        {
            get => _counterFont;
            set => SetValue(ref _counterFont, value, (st, val) => st.CounterFont = val);
        }

        public int this[BingoGoal goal]
        {
            get => _scores[goal].Value;
            set => _scores[goal].Value = value;
        }

        public void ResetCounters()
        {
            foreach (var score in _scores.Values)
            {
                score.Value = 0;
            }
        }

        private void SetValue<T>(ref T oldVal, T newVal, Action<HPBingoScoreTracker, T> setterAction)
        {
            if (setterAction is null)
                throw new ArgumentNullException(nameof(setterAction));

            if (EqualityComparer<T>.Default.Equals(newVal, oldVal))
                return;

            oldVal = newVal;
            foreach (var st in _scores.Values)
            {
                setterAction(st, newVal);
            }
        }
    }
}
