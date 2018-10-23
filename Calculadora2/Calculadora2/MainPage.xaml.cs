using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Calculadora2
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Igual.Click += Igual_Click;
        }

        private void Num_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (sender as Button);
            string datos = Pantalla1.Text;
            Pantalla1.Text = datos + boton.Content;
        }

        private void Num2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Vacio_Click(object sender, RoutedEventArgs e)
        {
            ShowMessage();
        }

        async void ShowMessage(string message = "Has pulsado un boton vacio.")
        {
            var dialog = new MessageDialog(message);
            await dialog.ShowAsync();
        }

        async void ShowMessage2(string message = "Has pulsado el boton igual.")
        {
            var dialog = new MessageDialog(message);
            await dialog.ShowAsync();
        }

        private void Igual_Click(object sender, RoutedEventArgs e)
        {
            ShowMessage2();
        }

        private void No_Numerico(object sender, RoutedEventArgs e)
        {

        }
    }
}
