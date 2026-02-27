using Reparai.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Reparai.DTO;

namespace Reparai
{
    public partial class Cadastro : ContentPage
    {
        private readonly AuthService _authService;

        public Cadastro(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            var Usuario = new RequestCadastroDTO
            {
                Nome = NomeEntry.Text,
                Email = EmailEntry.Text,
                CPF = CpfEntry.Text,
                Senha = SenhaEntry.Text,
                ConfirmarSenha = ConfirmarSenhaEntry.Text
            };

            var sucesso = await _authService.CadastrarUsuario(Usuario);

            if (sucesso)
            {
                await DisplayAlertAsync("Sucesso", "Cadastro realizado com sucesso!", "OK");
                await Shell.Current.GoToAsync(nameof(Login));
            }
            else
            {
                await DisplayAlertAsync("Erro", "Falha ao cadastrar usuário", "OK");
            }
        }
    }
}