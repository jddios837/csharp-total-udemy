using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Day15_Resultado_Deportivos;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        List<Juego> juegos = new List<Juego>();
        juegos.Add(
            new Juego()
                    {
                        Eq1 = "Barcelona",
                        Eq2 = "Real Madrid",
                        Puntaje1 = 3,
                        Puntaje2 = 2,
                        Progreso = 85
                    }
            );
        juegos.Add(
            new Juego()
            {
                Eq1 = "Juventus",
                Eq2 = "Italy",
                Puntaje1 = 4,
                Puntaje2 = 5,
                Progreso = 55
            }
        );

        lbJuego.Items = juegos;
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (lbJuego.SelectedItem != null)
        {
            // MessageBox Juego Selecionado .Show("Juego Seleccionado: ", (lbJuego.SelectedItem as Juego).Eq1 + ...)
        }
    }
}

public class Juego
{
    public int Puntaje2 { get; set; }
    public int Puntaje1 { get; set; }
    public string Eq1 { get; set; }
    public string Eq2 { get; set; }
    public int Progreso { get; set; }
}