# Nuits.MockExtensions
It is a extension library to use the Moq.

Now only one thing.  
You can easily publish PropertyChanged events from the Moq.  

If you are publishing from a Mock PropertyChanged typically describe this way.
```cs
sampleModel.Setup(m => m.Value).Returns("NewValue");
sampleModel.Raise(m => m.PropertyChanged += null, new PropertyChangedEventArgs("Value"));
```

Using this library makes you happy.
```cs
sampleModel.NotifyPropertyChanged(m => m.Value, "NewValue");
```

If I get a new idea, I may extend the functionality.

Only this.
So even if you use the direct code, I am happy.
