using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Day15_CheckBox;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void cbTodoHaCambiado(object sender, RoutedEventArgs e)
    {
        bool nuevoValor = (cbTodos.IsChecked == true);
        cbChile.IsChecked = nuevoValor;
        cbHongos.IsChecked = nuevoValor;
        cbMozzarela.IsChecked = nuevoValor;
    }
    
    private void cbSimpleHaCambiado(object sender, RoutedEventArgs e)
    {
        cbTodos.IsChecked = null;
        if (cbChile.IsChecked == true && cbHongos.IsChecked == true && cbMozzarela.IsChecked == true)
        {
            cbTodos.IsChecked = true;
        }
        if (cbChile.IsChecked == false && cbHongos.IsChecked == false && cbMozzarela.IsChecked == false)
        {
            cbTodos.IsChecked = false;
        }
    }
}