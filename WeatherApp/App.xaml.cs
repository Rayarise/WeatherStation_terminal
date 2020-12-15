﻿using System.Threading;
using System.Windows;
using System.Globalization;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// TODO 11 : Ajouter les ressources linguistiques au projet
        /// TODO 12 : Charger la langue d'affichage

        protected override void OnStartup(StartupEventArgs e)
        {
            var lang = WeatherApp.Properties.Settings.Default.Language;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);


            base.OnStartup(e);

            ApplicationView app = new ApplicationView();


            app.Show();

        }
    }
}
