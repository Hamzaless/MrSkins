using MrSkins;
using MrSkins.MrHamzaless;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrSkinsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public MinecraftSkin mcSkin;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username" || textBox1.Text == "") textBox1.Text = "MrHamzaless";
            mcSkin = new MinecraftSkin(textBox1.Text);
            pictureBox1.Image = mcSkin.GetSkin(SkinType.Skin);
            pictureBox2.Image = mcSkin.GetSkin(SkinType.Head);
            pictureBox3.Image = mcSkin.GetSkin(SkinType.Body);
            pictureBox4.Image = mcSkin.GetSkin(SkinType.bust);
            pictureBox5.Image = mcSkin.GetSkin(SkinType.twoD_Body);
            pictureBox6.Image = mcSkin.GetSkin(SkinType.twoD_Head);

        }
    }
}
