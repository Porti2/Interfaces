using App_Gimnasio.Models;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
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
    public sealed partial class AltaCliente : Page
    {
        SQLiteConnection conex;
        private List<ClientesB> Cliente;

        public AltaCliente()
        {
            this.InitializeComponent();
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "base.sqlite");
            conex = new SQLiteConnection(new SQLitePlatformWinRT(), path);
            conex.CreateTable<ClientesB>();

        }

        private void Alta_Click(object sender, RoutedEventArgs e)
        {
            AñadirCliente();

        }

        private void AñadirCliente()
        {
            String nombre, dni, telefono, correo, direccion, ciudad;
            nombre = NombreyApellidos.Text;
            dni = DNI.Text;
            telefono = NumeroTelefono.Text;
            correo = Email.Text;
            direccion = Dirección.Text;
            ciudad = Ciudad.Text;

            if (nombre == "")
            {
                NombreyApellidos.Focus(FocusState.Programmatic);
            }
            else
            {
                if (dni == "")
                {
                    DNI.Focus(FocusState.Programmatic);
                }
                else
                {
                    conex.Insert(new EntrenadoresB()
                    {
                        Nombre = nombre,
                        DNI = Convert.ToInt32(dni),
                        Telefono = Convert.ToInt32(telefono),
                        Correo = correo,
                        Direccion = direccion,
                        Ciudad = ciudad
                    });

                    NombreyApellidos.Text = "";
                    DNI.Text = "";
                    NumeroTelefono.Text = "";
                    Email.Text = "";
                    Dirección.Text = "";
                    Ciudad.Text = "";
                    CodigoPostal.Text = "";
                }
            }
        }
    }
}
