using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1B3Livraria.Desktop.DTOs;
using T1B3Livraria.Desktop.Helpers;

namespace T1B3Livraria.Desktop.Services
{
    public class AuthApiService
    {
        private readonly HttpClientHelper _http;

        public AuthApiService()
        {
            _http = HttpClientHelper.Instance;
        }

        public async Task<(bool Sucesso, UserResponseDto? User, string ErrorMessage)> LoginAsync(string email, string password)
        {
            var loginDto = new LoginRequestDto
            {
                Email = email,
                Password = password
            };

            var (sucesso, data, error) = await _http.PostAsync<UserResponseDto>(
                "/api/auth/login", loginDto);

            return (sucesso, data, error);
        }

       
        public async Task<(bool Sucesso, string ErrorMessage)> LogoutAsync()
        {
            var result = await _http.PostEmptyAsync("/api/auth/logout");

            _http.ClearCookies();

            return result;
        }


        public async Task<UserResponseDto?> GetCurrentUserAsync()
        {
            return await _http.GetAsync<UserResponseDto>("/api/auth/me");
        }


        public async Task<(bool Sucesso, string ErrorMessage)> RegisterAsync(
            string email, string password, string confirmPassword)
        {
            var dto = new RegisterRequestDto
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            var (success, _, error) = await _http.PostAsync<object>("/api/auth/register", dto);
            return (success, error);
        }
    }
}
