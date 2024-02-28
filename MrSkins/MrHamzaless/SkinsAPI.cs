using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MrSkins.MrHamzaless
{
    public static class SkinsAPI
    {

        private static string _baseUrl = "https://api.mrhamzaless.com/";
        public static async Task<Image> Get(string username, SkinType type)
        {
            
            string endpoint = GetEndpoint(type);
            Image image = null;
            var req = WebRequest.Create($"{_baseUrl}{endpoint}?name={username}");
            using (var res = req.GetResponse())
            using (var str = res.GetResponseStream())
            {
                image = Bitmap.FromStream(str);
            }
            return image;
        }

        private static string GetEndpoint(SkinType type)
        {
            switch (type)
            {
                case SkinType.Body:
                    return "skins/api/v1/body";
                case SkinType.Head:
                    return "skins/api/v1/head";
                case SkinType.Skin:
                    return "skins/api/v1/skin";
                case SkinType.bust:
                    return "skins/api/v1/bust";
                case SkinType.twoD_Body:
                    return "skins/api/v1/2d-body";
                case SkinType.twoD_Head:
                    return "skins/api/v1/2d-head";
                default:
                    return "skins/api/v1/body";
            }
        }
    }
}
