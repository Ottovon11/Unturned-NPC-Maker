using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Animation;
using MetroFramework.Drawing;
using MetroFramework.Controls;
using System.IO;

namespace Unturned_Npc_Maker
{
    public partial class Form1 : MetroForm
    {

        public Form1()
        {

            InitializeComponent();

        }

            private void metroTextBox9_Click(object sender, EventArgs e)
            {

            }

            private void metroTile2_Click(object sender, EventArgs e)
            {
            StreamWriter File = new StreamWriter("Asset.DAT");
           File.WriteLine("Type Npc");
            File.WriteLine("ID " + Npc_ID.Text);
            File.WriteLine("");
            File.WriteLine("Dialogue" + Dialogue_ID.Text);
            File.WriteLine("");
            File.WriteLine("" + ShirtBox.Text);
            File.WriteLine("" + PantsBox.Text);
            File.WriteLine("" + HatBox.Text);
            File.WriteLine("" + VestID.Text);
            File.WriteLine("" + BackpackID.Text);
            File.WriteLine("" + MaskID.Text);
            File.WriteLine("");
            File.WriteLine("" + GunID.Text);
            File.WriteLine("");
            File.WriteLine("" + BeardID.Text);
            File.WriteLine("" + FaceBox.Text);
            File.WriteLine("" + HairID.Text);
            File.WriteLine("");
            File.WriteLine("Color_Hair " + Hair_Color.Text);
            File.WriteLine("Color_Skin " + SkinID.Text);
            File.WriteLine("");
            File.WriteLine("" + PoseID.Text);
            File.Close();
        }

            private void metroTextBox14_Click(object sender, EventArgs e)
            {

            }

            private void metroLabel15_Click(object sender, EventArgs e)
            {

            }

            private void metroLabel16_Click(object sender, EventArgs e)
            {

            }

            private void metroTextBox15_Click(object sender, EventArgs e)
            {

            }

            private void metroTextBox12_Click(object sender, EventArgs e)
            {

            }

            private void metroTextBox11_Click(object sender, EventArgs e)
            {

            }

            private void metroTextBox1_Click(object sender, EventArgs e)
            {

            }

            private void metroTextBox2_Click(object sender, EventArgs e)
            {

            }

            private void metroTextBox3_Click(object sender, EventArgs e)
            {

            }

            private void metroTextBox4_Click(object sender, EventArgs e)
            {

            }

            private void metroTextBox5_Click(object sender, EventArgs e)
            {

            }

            private void metroTextBox6_Click(object sender, EventArgs e)
            {

            }

            private void metroTextBox7_Click(object sender, EventArgs e)
            {

            }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter("English.DAT");
            File.WriteLine("Name " + NpcEditor.Text);
            File.WriteLine("Character" + NpcGame.Text);
            File.Close();
        }
    }
}
