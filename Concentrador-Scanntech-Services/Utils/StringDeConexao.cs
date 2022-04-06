using Concentrador_Scanntech_Entities.Dtos;
using Concentrador_Scanntech_Entities.Utils;

namespace Concentrador_Scanntech_Services.Utils
{
    public class StringDeConexao
    {
        private const string CaminhoStringDeConexao = $"C:\\ConcentradorScanntech\\Conexao\\stringDeConexao.txt";
        private const string CaminhoItensString = $"C:\\ConcentradorScanntech\\Conexao\\itensString.txt";
        private const string CaminhoDiretorio = "C:/ConcentradorScanntech/Conexao";
        public static GerarStringDeConexaoDto LerTxt()
        {
            var linhas = File.ReadAllLines(CaminhoItensString);

            return new GerarStringDeConexaoDto
            {
                IpLocal = linhas[0],
                Porta = linhas[1],
                NomeDoBanco = linhas[2],
                Usuario = linhas[3],
                Senha = linhas[4],
                BancoDeDados = linhas[5]
            };
        }
        public static void GerarTxt(GerarStringDeConexaoDto stringDeConexao)
        {
            string montarStringDeConexao = string.Empty;

            if (stringDeConexao.BancoDeDados.Equals(BancoDeDados.PostgreSQL)) montarStringDeConexao = $@"User ID={stringDeConexao.Usuario};Password={stringDeConexao.Senha};Host={stringDeConexao.IpLocal};Port=5432;Database={stringDeConexao.NomeDoBanco};Pooling=true;";
            if (stringDeConexao.BancoDeDados.Equals(BancoDeDados.MySQL)) montarStringDeConexao = $@"Server={stringDeConexao.IpLocal};Port={stringDeConexao.Porta};Database={stringDeConexao.NomeDoBanco};Uid={stringDeConexao.Usuario};Pwd={stringDeConexao.Senha};";
            if (stringDeConexao.BancoDeDados.Equals(BancoDeDados.SQLServer)) montarStringDeConexao = $@"Data Source={stringDeConexao.IpLocal}; Initial Catalog={stringDeConexao.NomeDoBanco}; Integrated Security=SSPI;";
            var ItemAItem = new List<string>
            {
                stringDeConexao.IpLocal, stringDeConexao.Porta,
                stringDeConexao.NomeDoBanco, stringDeConexao.Usuario,
                stringDeConexao.Senha, stringDeConexao.BancoDeDados
            };

            StreamWriter writer;

            if (!Directory.Exists(CaminhoDiretorio))
            {
                Directory.CreateDirectory(CaminhoDiretorio);
            }

            if (File.Exists(CaminhoStringDeConexao))
            {
                File.Delete(CaminhoStringDeConexao);
                writer = File.CreateText(CaminhoStringDeConexao);
                writer.Write(montarStringDeConexao);
                writer.Close();

                if (File.Exists(CaminhoItensString)) File.Delete(CaminhoItensString);
                writer = File.CreateText(CaminhoItensString);

                foreach (var item in ItemAItem)
                {
                    writer.WriteLine(item);
                }
                writer.Close();
            }
            else
            {
                writer = File.CreateText(CaminhoStringDeConexao);
                writer.Write(montarStringDeConexao);
                writer.Close();

                writer = File.CreateText(CaminhoItensString);

                foreach (var item in ItemAItem)
                {
                    writer.WriteLine(item);
                }
                writer.Close();
            }
        }
    }
}
