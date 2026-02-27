using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using Reparai.DTO;


namespace Reparai.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private string baseUrl = "https://localhost:7177/"; 
        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;


            

        }



        public async Task<ResponseLoginDTO> LoginAsync(RequestLoginDTO dadosUsuario)
        {
            var response = await _httpClient.PostAsJsonAsync($"{baseUrl}api/Usuarios/login", dadosUsuario);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<ResponseLoginDTO>();

                return result!;
            }

            return new ResponseLoginDTO
            {
                Erro = true,
                Message = "Login falhou. Tente novamente."
            };
        }

        //  MÉTODO PARA CADASTRO
        public async Task<bool> CadastrarUsuario(RequestCadastroDTO Usuario)
        {
            var response = await _httpClient.PostAsJsonAsync($"{baseUrl}api/Usuarios/cadastrar", Usuario);

            return response.IsSuccessStatusCode;
        }
    }
}