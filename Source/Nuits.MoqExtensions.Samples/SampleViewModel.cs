namespace Nuits.MoqExtensions.Samples
{
    public class SampleViewModel
    {
        private readonly ISampleModel _sampleModel;
        public string ViewModelValue { get; private set; }

        public SampleViewModel(ISampleModel sampleModel)
        {
            _sampleModel = sampleModel;
            _sampleModel.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == "Value")
                {
                    ViewModelValue = _sampleModel.Value;
                }
            };
        }
    }
}
