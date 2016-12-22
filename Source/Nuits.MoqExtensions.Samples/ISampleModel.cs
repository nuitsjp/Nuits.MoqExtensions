using System.ComponentModel;

namespace Nuits.MoqExtensions.Samples
{
    public interface ISampleModel : INotifyPropertyChanged
    {
        string Value { get; set; }
    }
}
