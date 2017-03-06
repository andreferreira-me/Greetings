﻿using System;
using Xamarin.Forms;

namespace Greetings
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            var MyLabel = new Label();
            MyLabel.Text = "Greetings, Xamarin.Forms!";
            this.Content = MyLabel;

            MyLabel.HorizontalTextAlignment = TextAlignment.Center;
            MyLabel.VerticalTextAlignment = TextAlignment.Center;

            //MyLabel.HorizontalOptions = LayoutOptions.Center;
            //MyLabel.VerticalOptions = LayoutOptions.Center;

            // Adiciona Padding no iOS para evitar barra de status do device

            Device.OnPlatform(iOS: () =>
            {
                Padding = new Thickness(0, 20, 0, 0);
            });
            // ambos os projetos PCL e SAP.No entanto, você não pode acessar as APIs dentro de
            // plataformas individuais. Para fazer isso vamos precisar DependencyService.
        }
    }
}