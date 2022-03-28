
using System.Security.Cryptography;
using System.Text;

namespace Concentrador_Scanntech_Services.Utils
{
    public class Senha
    {
        public static string CriptografarMD5(string value)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(value);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
