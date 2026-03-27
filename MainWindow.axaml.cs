using System.Globalization;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace _;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Onclick(object? sender, RoutedEventArgs e)
    {
        if (double.TryParse(Celsius.Text, out double c)) // ✔ nom corrigé
        {
            var f = c * (9d / 5d) + 32; // ✔ nom corrigé
            Fahrenheit.Text = f.ToString(CultureInfo.InvariantCulture); // ✔ culture explicite
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }
    }
}