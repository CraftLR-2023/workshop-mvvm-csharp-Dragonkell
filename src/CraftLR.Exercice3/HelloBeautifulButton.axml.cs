using System;

using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging; // Assurez-vous d'importer cette directive

namespace CraftLR.Exercice3;

public partial class HelloBeautifulButton : Window
{
    public HelloBeautifulButton()
    {
        InitializeComponent();
        LoadImage();
    }

    private void LoadImage()
    {
            var image = new Bitmap("Assets/logo.png");
            var button = this.FindControl<Button>("Bouton1");
            button.Content = new Image { Source = image };
    }
}