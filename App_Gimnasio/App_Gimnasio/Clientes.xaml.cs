﻿using App_Gimnasio.Models;
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
    public sealed partial class Clientes : Page
    {
        SQLiteConnection conex;
        private List<ClientesB> Cliente;
        int dni;

        public Clientes()
        {
            this.InitializeComponent();
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "base.sqlite");
            conex = new SQLiteConnection(new SQLitePlatformWinRT(), path);
            GetClientes();
        }

        public void GetClientes()
        {
            Cliente = new List<ClientesB>();
            var query = conex.Table<EntrenadoresB>();
            foreach (var data in query)
            {
                Cliente.Add(new ClientesB
                {
                    ID = data.ID,
                    Nombre = data.Nombre,
                    DNI = data.DNI,
                    Telefono = data.Telefono,
                    Correo = data.Correo,
                    Direccion = data.Direccion,
                    Ciudad = data.Ciudad
                });
            }
            listEntrenadores.ItemsSource = null;
            listEntrenadores.ItemsSource = Cliente;

        }

        private void listEntrenadores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EntrenadoresB selected = (EntrenadoresB)listEntrenadores.SelectedItem;
            if (selected != null)
            {
                dni = selected.DNI;
            }

        }

        private void Borrar_Click(object sender, RoutedEventArgs e)
        {
            conex.RunInTransaction(() =>
            {
                var p = conex.Execute("DELETE FROM EntrenadoresB WHERE DNI = ?", dni);
            });
            GetClientes();
        }

        private void Añadir_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AltaEntrenador));
        }
    }
}
