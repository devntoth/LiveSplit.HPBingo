using System;
using System.Drawing;
using System.Windows.Forms;
using LiveSplit.HPBingo.Types;

namespace LiveSplit.HPBingo.Forms
{
    public partial class HPBingoScoreTracker : UserControl
    {
        public HPBingoScoreTracker()
        {
            InitializeComponent();

            Value = 0;
        }

        public BingoGoal GoalType { get; set; }

        public string Label
        {
            get => scoreLabel.Text;
            set => scoreLabel.Text = value;
        }

        public Color LabelColor 
        { 
            get => scoreLabel.ForeColor;
            set => scoreLabel.ForeColor = value;
        }

        public Color CounterColor 
        { 
            get => scoreValue.ForeColor;
            set => scoreValue.ForeColor = value;
        }

        public Font LabelFont 
        { 
            get => scoreLabel.Font;
            set => scoreLabel.Font = value;
        }

        public Font CounterFont 
        { 
            get => scoreValue.Font;
            set => scoreValue.Font = value;
        }

        private int _value;
        public int Value 
        {
            get => _value;
            set
            {
                if (_value.Equals(value))
                    return;

                _value = value;
                scoreValue.Text = value.ToString();
            }
        }

        private void OnScoreTrackerLoad(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
    }
}
