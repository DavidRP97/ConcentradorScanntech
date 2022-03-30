using static Concentrador_Scanntech_Entities.Utils.Enums;

namespace Concentrador_Scanntech_Entities.Dtos
{
    public class GerarStringDeConexaoDto
    {
        public string IpLocal { get; set; }
        public string Porta { get; set; }
        public string NomeDoBanco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string BancoDeDados { get; set; }  
    }
}
