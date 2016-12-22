using System.ComponentModel;

namespace Nuits.MoqExtensions.Samples
{
    public class SampleModel : ISampleModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _value;

        public string Value
        {
            get { return _value; }
            set
            {
                if (!Equals(_value, value))
                {
                    _value = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                }
            }
            
        }
    }
}
