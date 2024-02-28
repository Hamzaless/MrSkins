using MrSkins.MrHamzaless;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrSkins
{
    public class MinecraftSkin
    {

        private static string _username;

        public MinecraftSkin(string username)
        {
            _username = username;
        }

        public Image GetSkin(SkinType type)
        {
            return SkinsAPI.Get(_username, type).Result;
        }

    }
}
