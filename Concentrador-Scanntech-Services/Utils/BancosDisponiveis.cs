using Concentrador_Scanntech_Entities.Utils;

namespace Concentrador_Scanntech_Services.Utils
{
    public static class BancosDisponiveis
    {
        public static List<string> ListaDeBancos()
        {
            var lista = new List<string>();
            lista.Add(BancoDeDados.MySQL);
            lista.Add(BancoDeDados.PostgreSQL);
            lista.Add(BancoDeDados.SQLServer);

            return lista;
        }
    }
}
