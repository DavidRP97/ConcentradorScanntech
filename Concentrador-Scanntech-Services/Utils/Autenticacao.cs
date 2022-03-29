using Concentrador_Scanntech_Entities.Model.Definicoes;
using System.Text;

namespace Concentrador_Scanntech_Services.Utils
{
    public static class Autenticacao
    {
        public static string Basic(string senha, string usuario)
        {
            var authData = string.Format("{0}:{1}", usuario, senha);
            byte[] byteAuthData = Encoding.ASCII.GetBytes(authData);
            var converted = Convert.ToBase64String(byteAuthData);

            return $"{converted}";
        }
    }
}
