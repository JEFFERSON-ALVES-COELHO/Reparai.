using System;
using System.Collections.Generic;
using System.Text;

namespace Reparai
{
    partial class Cadastro

    {

        public Cadastro()

        {

            InitializeComponent();

        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Aqui você salva o cadastro

            await DisplayAlertAsync("Sucesso", "Cadastro realizado com sucesso!", "OK");

            await Shell.Current.GoToAsync("//MainPage");
        }

    }

}