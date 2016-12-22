using System.ComponentModel;
using Moq;
using Nuits.Moq;
using Xunit;

namespace Nuits.MockExtensions.Tests
{
    public class MoqExtensionsFixture
    {
        [Fact]
        public void NotifyPropertyChanged()
        {
            var mock = new Mock<IMockInterface>();
            Assert.PropertyChanged(mock.Object, "Property", () => mock.NotifyPropertyChanged(m => m.Property, "newValue"));
            Assert.Equal("newValue", mock.Object.Property);
        }
    }

    public interface IMockInterface : INotifyPropertyChanged
    {
        string Property { get; }
    }
}
