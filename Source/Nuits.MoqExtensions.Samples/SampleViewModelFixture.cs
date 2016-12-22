using System.ComponentModel;
using Moq;
using Nuits.Moq;
using Xunit;

namespace Nuits.MoqExtensions.Samples
{
    public class SampleViewModelFixture
    {
        [Fact]
        public void WhenDoNotUseExtensions()
        {
            var sampleModel = new Mock<ISampleModel>();
            var actual = new SampleViewModel(sampleModel.Object);

            sampleModel.Setup(m => m.Value).Returns("NewValue");
            sampleModel.Raise(m => m.PropertyChanged += null, new PropertyChangedEventArgs("Value"));

            Assert.Equal("NewValue", actual.ViewModelValue);
        }

        [Fact]
        public void WhenUseExtensions()
        {
            var sampleModel = new Mock<ISampleModel>();
            var actual = new SampleViewModel(sampleModel.Object);

            sampleModel.NotifyPropertyChanged(m => m.Value, "NewValue");

            Assert.Equal("NewValue", actual.ViewModelValue);
        }
    }
}
