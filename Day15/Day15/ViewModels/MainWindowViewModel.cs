using System.ComponentModel;

namespace Day15.ViewModels;

public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
{
    public string Greeting => "Welcome to Avalonia!";
}