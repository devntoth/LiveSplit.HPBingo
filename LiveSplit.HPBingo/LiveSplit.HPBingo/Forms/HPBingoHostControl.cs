using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LiveSplit.HPBingo.Types;
using LiveSplit.HPBingo.Utils;
using LiveSplit.Model;

namespace LiveSplit.HPBingo.Forms
{
    public partial class HPBingoHostControl : UserControl
    {
        private readonly Dictionary<BingoGoal, ValueSource> _scores;

        private int _currentGoals = 0;
        private int _requiredGoals = 0;

        public HPBingoHostControl()
        {
            InitializeComponent();
            SetupStyleBindings();

            string labelTextName = nameof(Label.Text);
            _scores = new Dictionary<BingoGoal, ValueSource>
            {
                { BingoGoal.BG_Star, new ValueSource(starValue, labelTextName) },
                { BingoGoal.BG_Armorstand, new ValueSource(armorstandValue, labelTextName) },
                { BingoGoal.BG_Cauldron, new ValueSource(cauldronValue, labelTextName) },
                { BingoGoal.BG_Pot, new ValueSource(potValue, labelTextName) },
                { BingoGoal.BG_Imp, new ValueSource(impValue, labelTextName) },
                { BingoGoal.BG_Spider, new ValueSource(spiderValue, labelTextName) },
                { BingoGoal.BG_Pixie, new ValueSource(pixieValue, labelTextName) },
                { BingoGoal.BG_Frog, new ValueSource(frogValue, labelTextName) },
                { BingoGoal.BG_Bark, new ValueSource(barkValue, labelTextName) },
                { BingoGoal.BG_Mucus, new ValueSource(mucusValue, labelTextName) }
            };
        }

        private void SetupStyleBindings()
        {
            string foreColorName = nameof(Label.ForeColor);
            string fontName = nameof(Label.Font);

            label1.DataBindings.Add(foreColorName, this, nameof(LabelColor));
            label1.DataBindings.Add(fontName, this, nameof(LabelFont));
            label2.DataBindings.Add(foreColorName, this, nameof(LabelColor));
            label2.DataBindings.Add(fontName, this, nameof(LabelFont));
            label3.DataBindings.Add(foreColorName, this, nameof(LabelColor));
            label3.DataBindings.Add(fontName, this, nameof(LabelFont));
            label4.DataBindings.Add(foreColorName, this, nameof(LabelColor));
            label4.DataBindings.Add(fontName, this, nameof(LabelFont));
            label5.DataBindings.Add(foreColorName, this, nameof(LabelColor));
            label5.DataBindings.Add(fontName, this, nameof(LabelFont));
            label6.DataBindings.Add(foreColorName, this, nameof(LabelColor));
            label6.DataBindings.Add(fontName, this, nameof(LabelFont));
            label7.DataBindings.Add(foreColorName, this, nameof(LabelColor));
            label7.DataBindings.Add(fontName, this, nameof(LabelFont));
            label8.DataBindings.Add(foreColorName, this, nameof(LabelColor));
            label8.DataBindings.Add(fontName, this, nameof(LabelFont));
            label9.DataBindings.Add(foreColorName, this, nameof(LabelColor));
            label9.DataBindings.Add(fontName, this, nameof(LabelFont));
            label10.DataBindings.Add(foreColorName, this, nameof(LabelColor));
            label10.DataBindings.Add(fontName, this, nameof(LabelFont));
            label11.DataBindings.Add(foreColorName, this, nameof(LabelColor));
            label11.DataBindings.Add(fontName, this, nameof(LabelFont));

            starValue.DataBindings.Add(foreColorName, this, nameof(CounterColor));
            starValue.DataBindings.Add(fontName, this, nameof(CounterFont));
            armorstandValue.DataBindings.Add(foreColorName, this, nameof(CounterColor));
            armorstandValue.DataBindings.Add(fontName, this, nameof(CounterFont));
            cauldronValue.DataBindings.Add(foreColorName, this, nameof(CounterColor));
            cauldronValue.DataBindings.Add(fontName, this, nameof(CounterFont));
            potValue.DataBindings.Add(foreColorName, this, nameof(CounterColor));
            potValue.DataBindings.Add(fontName, this, nameof(CounterFont));
            impValue.DataBindings.Add(foreColorName, this, nameof(CounterColor));
            impValue.DataBindings.Add(fontName, this, nameof(CounterFont));
            spiderValue.DataBindings.Add(foreColorName, this, nameof(CounterColor));
            spiderValue.DataBindings.Add(fontName, this, nameof(CounterFont));
            pixieValue.DataBindings.Add(foreColorName, this, nameof(CounterColor));
            pixieValue.DataBindings.Add(fontName, this, nameof(CounterFont));
            frogValue.DataBindings.Add(foreColorName, this, nameof(CounterColor));
            frogValue.DataBindings.Add(fontName, this, nameof(CounterFont));
            barkValue.DataBindings.Add(foreColorName, this, nameof(CounterColor));
            barkValue.DataBindings.Add(fontName, this, nameof(CounterFont));
            mucusValue.DataBindings.Add(foreColorName, this, nameof(CounterColor));
            mucusValue.DataBindings.Add(fontName, this, nameof(CounterFont));
        }

        private Color _labelColor = Color.MediumOrchid;
        public Color LabelColor
        {
            get => _labelColor;
            set => SetValue(ref _labelColor, value);
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
