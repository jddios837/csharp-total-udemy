using System.ComponentModel;

namespace Day15.Models;

public class Suma : INotifyPropertyChanged
{
    private string num1;
    private string num2;
    private string resultado;

    public string Num1
    {
        get
        {
            return num1;
        }
        set
        {
            int numero;
            bool res = int.TryParse(value, out numero);
            if (res) num1 = value;
            OnPropertyChange("Num1");
            OnPropertyChange("Resultado");
        }
    }
    
    public string Num2
    {
        get
        {
            return num2;
        }
        set
        {
            int numero;
            bool res = int.TryParse(value, out numero);
            if (res) num2 = value;
            OnPropertyChange("Num2");
            OnPropertyChange("Resultado");
        }
    }
    
    public string Resultado
    {
        get
        {
            int res = int.Parse(Num1) + int.Parse(Num2);
            return resultado;
        }
        set
        {
            int res = int.Parse(Num1) + int.Parse(Num2);
            resultado = res.ToString();
            OnPropertyChange("Resultado");
        }
    }
    
    
    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChange(string propiedad)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            
        }
    }
}