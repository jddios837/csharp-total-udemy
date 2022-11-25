using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using ReactiveUI;

namespace Day14.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        TextBlock1.Text = "Button clicked - Event Direct";
        // MessageBox.Show("Hola");
        // throw new System.NotImplementedException();
    }

    private void InputElement_OnPointerReleased(object? sender, PointerReleasedEventArgs e)
    {
        TextBlock1.Text = "Button clicked - Bubbling";
        //throw new System.NotImplementedException();
    }

    private void InputElement_OnPointerEnter(object? sender, PointerEventArgs e)
    {
        TextBlock1.FontSize = 30;
    }
}