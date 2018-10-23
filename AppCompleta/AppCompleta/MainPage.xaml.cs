using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AppCompleta.Models;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace AppCompleta
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<NewsItem> Finanzas;
        public MainPage()
        {
            this.InitializeComponent();
            Finanzas = ItemsManager.getNewsItems();
            MyFrame.Navigate(typeof(Financial));
        }

        private void Financial_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Finanzas = ItemsManager.getNewsItems();
            Frame.Navigate(typeof(Financial));
        }

        private void Food_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Food));
        }
    }
}
