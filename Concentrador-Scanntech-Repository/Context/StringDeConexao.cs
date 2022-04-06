namespace Concentrador_Scanntech_Repository.Context
{
    internal static class StringDeConexao
    {
        private const string ConnectionStringPath = $"C:\\ConcentradorScanntech\\Conexao\\stringDeConexao.txt";       
        private const string CaminhoItensString = $"C:\\ConcentradorScanntech\\Conexao\\itensString.txt";
        internal static string Gerar()
        {
            if (File.Exists(ConnectionStringPath))
            {
                var path = File.ReadAllText(ConnectionStringPath);

                return path;
            }
            return string.Empty;
        }

        internal static string Banco()
        {            
            var banco = File.ReadAllLines(CaminhoItensString);

            return banco[5];
        }
    }
}
