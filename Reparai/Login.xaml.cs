using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Maui.Controls;
using Reparai.Services;
using Reparai.DTO;

namespace Reparai
{
    public partial class Login
    {
        private readonly AuthService _authService;
        public Login(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        public Login()
        {
            InitializeComponent();
        }
        async void OnCadastrarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Cadastro");
        }

        async void OnEntrarClicked(object sender, EventArgs e)
        {
            String email = Email.Text;
            String senha = Senha.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                await DisplayAlertAsync("Campos Obrigatórios", "Por favor, preencha todos os campos.", "OK");
                return;
            }

            RequestLoginDTO dadosUsuario = new RequestLoginDTO
            {
                Email = email,
                Senha = senha
            };

            ResponseLoginDTO responseLogin = await _authService.LoginAsync(dadosUsuario);

            if (responseLogin.Success)
            {
                await Shell.Current.GoToAsync("Cadastro");
                return;
            }
            // await Shell.Current.GoToAsync("Cadastro");

            await DisplayAlertAsync("Login Falhou", "Email ou senha incorretos. Tente novamente.", "OK");
        }

    }
}