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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace App_Gimnasio
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ListView : Page
    {
        public ListView()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(AltaEntrenador));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (MySplitView.IsPaneOpen)
            {
                MySplitView.IsPaneOpen = false;
            }
            else
            {
                MySplitView.IsPaneOpen = true;
            }

            HamburgerButton.IsChecked = false;
        }

        private void Entrenadores_Checked(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Entrenadores));
            Entrenadores.IsChecked = true;
        }

        private void AñadirEntrenador_Checked(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(AltaEntrenador));
            AñadirEntrenador.IsChecked = true;
        }

        private void Clientes_Checked(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Clientes));
            Clientes.IsChecked = true;
        }

        private void AñadirCliente_Checked(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(AltaCliente));
            AñadirCliente.IsChecked = true;
        }

        private void GoBack_Checked(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
            }

            GoBack.IsChecked = false;
        }
    }
}
