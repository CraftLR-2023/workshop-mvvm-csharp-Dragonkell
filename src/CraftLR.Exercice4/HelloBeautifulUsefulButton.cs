using System;

using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging; // Assurez-vous d'importer cette directive

namespace CraftLR.Exercice4;

public partial class HelloBeautifulUsefulButton : Window
{
    public HelloBeautifulUsefulButton()
    {
        InitializeComponent();
        LoadImage();
    }

    private void LoadImage()
    {
            var image = new Bitmap("Assets/logo.png");
            var button = this.FindControl<Button>("Bouton1");
            button.Content = new Image { Source = image };
            button.Click += Button_OnClick;
    }

    private void Button_OnClick(object sender, RoutedEventArgs eventData)
    {
        var button = this.FindControl<Button>("Bouton1");
        button.Click += (sender, e) => Console.WriteLine("Bouton actionné");
    }
}