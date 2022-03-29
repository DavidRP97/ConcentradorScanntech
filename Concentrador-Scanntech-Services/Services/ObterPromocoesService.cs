using Concentrador_Scanntech_Entities.Dtos.Promocoes;
using Concentrador_Scanntech_Entities.Model.Definicoes;
using Concentrador_Scanntech_Services.Interfaces;
using Concentrador_Scanntech_Services.Utils;
using System.Net.Http.Headers;

namespace Concentrador_Scanntech_Services.Services
{
    public class ObterPromocoesService : IObterPromocoesService
    {
        private readonly HttpClient _httpClient;

        public ObterPromocoesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<RootDto> ObterPromocoesScanntech(DefinicoesScanntech definicoes, string url)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", $"{Autenticacao.Basic(definicoes.Senha, definicoes.Usuario)}");
            var response = await _httpClient.GetAsync(MontarUrl.Promocoes(definicoes, url));
            return await response.ReadContentAs<RootDto>();
        }
    }
}
