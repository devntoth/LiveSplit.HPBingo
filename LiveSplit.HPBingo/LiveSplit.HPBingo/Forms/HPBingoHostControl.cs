using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiveSplit.HPBingo.Types;

namespace LiveSplit.HPBingo.Forms
{
    public partial class HPBingoHostControl : UserControl
    {
        private readonly Dictionary<BingoGoal, HPBingoScoreTracker> _scores;

        private int _currentGoals = 0;
        private int _requiredGoals = 0;

        public HPBingoHostControl()
        {
            InitializeComponent();

            _scores = counterTable.Controls.OfType<HPBingoScoreTracker>().ToDictionary(x => x.GoalType);
        }

        private Color _labelColor = Color.MediumOrchid;
        public Color LabelColor
        {
            get => _labelColor;
            set
            {
                if (_labelColor.Equals(value))
                    return;

                _labelColor = value;
            }
        }

        private Color _counterColor = Color.AliceBlue;
        public Color CounterColor
        {
            get => _counterColor;
            set 
            { 
                if (SetValue(ref _counterColor, value))
                    bingoValue.ForeColor = value;
            }
        }

        private Font _labelFont;
        public Font LabelFont
        {
            get => _labelFont;
            set => SetValue(ref _labelFont, value);
        }

        private Font _counterFont;
        public Font CounterFont
        {
            get => _counterFont;
            set 
            { 
                if (SetValue(ref _counterFont, value))
                    bingoValue.Font = value;
            }
        }

        public int CurrentGoals 
        { 
            get => _currentGoals;
            set
            {
                if (_currentGoals == value) 
                    return;

                _currentGoals = value;
                UpdateBingoLabel();
            }
        }
        public int RequiredGoals
        {
            get => _requiredGoals;
            set
            {
                if (_requiredGoals == value) 
                    return;

                _requiredGoals = value;
                UpdateBingoLabel();
            }
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

            CurrentGoals = 0;
        }

        private bool SetValue<T>(ref T oldVal, T newVal)
        {
            if (EqualityComparer<T>.Default.Equals(newVal, oldVal))
                return false;

            oldVal = newVal;
            return true;
        }

        private void UpdateBingoLabel()
        {
            bingoValue.Text = $"{CurrentGoals} / {RequiredGoals}";
        }
    }
}
