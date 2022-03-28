using Concentrador_Scanntech_Entities.Utils;
using static Concentrador_Scanntech_Entities.Utils.Enums;

namespace Concentrador_Scanntech_Services.Factory.UrlFactory
{
    public class UrlFactory : IUrlFactory
    {
        public string Url(UrlEnums url)
        {
            switch (url)
            {
                case UrlEnums.Url1:
                    return ConstFactory.Url1;
                case UrlEnums.Url2:
                    return ConstFactory.Url2; 
                case UrlEnums.Url3:
                    return ConstFactory.Url3; 
                case UrlEnums.Url4:
                    return ConstFactory.Url4; 
                    default : return "";
            }
        }
    }
}
