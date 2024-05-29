using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Styling;

namespace AvaloniaThemeSwitch;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ThemeSwitch_OnIsCheckedChanged(object? sender, RoutedEventArgs e)
    {
        var app = Application.Current;
        if (app is null) return;
        var isDark = themeSwitch.IsChecked ?? false;
        app.RequestedThemeVariant =  isDark ? ThemeVariant.Dark : ThemeVariant.Light;
    }
}