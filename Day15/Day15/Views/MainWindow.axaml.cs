using Avalonia.Controls;
using Day15.Models;

namespace Day15.Views;

public partial class MainWindow : Window
{
    public Suma ObjetoSuma { get; set; }
    public MainWindow()
    {
        InitializeComponent();

        ObjetoSuma = new Suma { Num1 = "1", Num2 = "2"};
        this.DataContext = ObjetoSuma;
    }
}