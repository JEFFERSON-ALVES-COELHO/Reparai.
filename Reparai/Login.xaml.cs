using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Maui.Controls;
using Reparai.DTO;
using Reparai.Services;
using System.Linq.Expressions;

namespace Reparai
{
    partial class Login
    {
        private readonly AuthService _authservice;
        public Login(AuthService authService)
        {
            InitializeComponent();
            _authservice = authService;
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

        DisplayLoding();
        string email = Email.Text;
        string senha = Senha.Text;

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(senha))
            {
                await DisplayAlertAsync("Campos obrigatórios", "Por favor, preencha todos os campos.", "OK");
        DisplayLoding();
                return;

        }
        
            try// Tentar executar a inscrição
            {
            
            RequestLoginDTO dadosUsuarioForm = new RequestLoginDTO
            {
                Email = email,
                Senha = senha

            };

    ResponseLoginDTO respostaLogin = await _authservice.LoginAsync(dadosUsuarioForm);



            if (!respostaLogin.Erro)
            {
                await Shell.Current.GoToAsync("CadastroUsuario");
                return;
            }

           await DisplayAlertAsync("Erro de login", "Dados inválidos. Verifique seus dados e tente novamente", "Ok");



            }
            catch (Exception erro)//Capturar o erro caso ocorra
            {
                    throw new Exception($"Ocorreu um erro durante o login: {erro.Message}");
                }
            finally { //Sempre executa!!
                    DisplayLoding();

                }





        }

        public void DisplayLoding()
        {

            btnEntrar.IsVisible = !btnEntrar.IsVisible;
            loading.IsVisible = !loading.IsVisible;

        }

        }


}