using System;
using System.Collections.Generic;
using System.Text;

namespace Reparai
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }


        async void OnReportarProblemaClicked(object sender, EventArgs e)
        {
            await DisplayAlertAsync("Reportar Problema", "Funcionalidade de reporte será implementada aqui.", "OK");
        }


        async void OnAcompanharRelatosClicked(object sender, EventArgs e)
        {
            await DisplayAlertAsync("Acompanhar Relatos", "Tela de acompanhamento de relatos.", "OK");
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Login");
        }
    }
}