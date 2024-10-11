using System.Windows.Forms;

namespace LiveSplit.HPBingo.Utils
{
    public class ValueSource
    {
        private int _value;

        public ValueSource(Control control, string propertyName, int defaultValue = 0)
        {
            Binding = new Binding(propertyName, this, nameof(Value));
            control.DataBindings.Add(Binding);
            Value = defaultValue;
        }

        public Binding Binding { get; }
        public int Value
        {
            get => _value;
            set
            {
                if (_value == value)
                    return;

                _value = value;
                Binding.ReadValue();
            }
        }
    }
}
