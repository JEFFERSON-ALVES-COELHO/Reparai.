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

        private const string BaseUrl = "https://localhost:7177/";

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<ResponseLoginDTO> LoginAsync(RequestLoginDTO dadosUsuario)
        {
            var response = await _httpClient.PostAsJsonAsync($"{BaseUrl}/api/Usuarios/login", dadosUsuario);


            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<ResponseLoginDTO>();

                return new ResponseLoginDTO
                {

                    Erro = false,
                    Message = "Login realizado com sucesso"


                };

            }

            return new ResponseLoginDTO
            {

                Erro = true,
                Message = "Login falhou. Tente novamente."

            };


        }
    }
}