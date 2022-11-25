using Avalonia.Controls;
using Avalonia.Media;

namespace Day15_ComboBox;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        ComboBoxColores.Items = typeof(Colors).GetProperties();
    }
}