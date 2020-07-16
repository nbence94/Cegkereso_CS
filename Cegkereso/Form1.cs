using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cegkereso
{
    public partial class Form1 : Form
    {

        public int hossz = 0;
        public string[,] Datas = new string[1000, 4];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox1.Image = Image.FromFile(@"Images\nincs.jpg");
            Beolvas();
            cegRb.Checked = true;
        }

        public void Beolvas()
        {
            int index = 0;
            string curFile = @"Data\places.bqf";
            if (File.Exists(curFile))
            {
                using (FileStream fs = new FileStream(@"Data\places.bqf", FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] F = sr.ReadLine().Split('|');

                            Datas[index, 0] = F[0];//Cegnev
                            Datas[index, 1] = F[1];//Szam
                            Datas[index, 2] = F[2];//Zona
                            Datas[index, 3] = F[3];//Egyeb


                            
                            index++;
                        }
                        hossz = index;
                        index = 0;
                        sr.Close();
                    }
                    fs.Close();
                }
            }
            else
            {
                File.Create(@"Data\places.bqf");
            }
        }

        private void Keres()
        {
            listBox1.Items.Clear();
            bool talalt = false;
            short keresSzam = 0;
            if (cegRb.Checked == true)
            {
                keresSzam = 0;
            } else if(otherRb.Checked == true)
            {
                keresSzam = 3;
            }


            for(int i = 0; i < hossz; i++)
            {
                if(keresTb.Text.ToLower() == Datas[i, keresSzam].ToLower())
                {
                    other_info.Text = "";
                    ceg_nev.Text = Datas[i, 0];
                    ceg_szam.Text = Datas[i, 1];
                    map_loc.Text = Datas[i, 2];
                    string[] Others = Datas[i, 3].Split(',');
                    for(int j = 0; j < Others.Length; j++)
                    {
                        other_info.Text += Others[j] + "\n";
                    }
                    if (Datas[i, 2] != "-")
                    {
                        PictureBox1.Image = Image.FromFile(@"Images\" + Datas[i, 2] + ".jpg");
                    }
                    else
                    {
                        PictureBox1.Image = Image.FromFile(@"Images\nincs.jpg");
                    }
                    talalt = true;

                }
                else if(Datas[i, keresSzam].ToLower().Contains(keresTb.Text.ToLower()))
                {
                    listBox1.Items.Add(Datas[i,0]);
                    talalt = true;
                    continue;
                }
            }
            if (talalt == false)
            {
                MessageBox.Show("Nincs találat");
            }
        }



        private void keresBtn_Click(object sender, EventArgs e)
        {
            if(keresTb.Text == "adminlogin")
            {
                Leltar lt = new Leltar();
                for (int i = 0; i < hossz; i++)
                {
                    lt.Datas[i, 0] = Datas[i, 0];
                    lt.Datas[i, 1] = Datas[i, 1];
                    lt.Datas[i, 2] = Datas[i, 2];
                    lt.Datas[i, 3] = Datas[i, 3];
                }
                lt.hossz = hossz;
                lt.Show();
                keresTb.Text = "";
            }
            else 
            {
                Keres();
            }
        }

        private void keresTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (keresTb.Text == "adminlogin")
                {
                    Leltar lt = new Leltar();
                    for (int i = 0; i < hossz; i++)
                    {
                        lt.Datas[i, 0] = Datas[i, 0];
                        lt.Datas[i, 1] = Datas[i, 1];
                        lt.Datas[i, 2] = Datas[i, 2];
                        lt.Datas[i, 3] = Datas[i, 3];
                    }
                    lt.hossz = hossz;
                    lt.Show();
                    keresTb.Text = "";
                }
                else
                {
                    Keres();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < hossz; i++)
            {
                if(Datas[i, 0] == listBox1.SelectedItem.ToString())
                {
                    other_info.Text = "";
                    ceg_nev.Text = Datas[i, 0];
                    ceg_szam.Text = Datas[i, 1];
                    map_loc.Text = Datas[i, 2];
                    string[] Others = Datas[i, 3].Split(',');
                    for (int j = 0; j < Others.Length; j++)
                    {
                        other_info.Text += Others[j] + "\n";
                    }
                    if (Datas[i, 2] != "-")
                    {
                        PictureBox1.Image = Image.FromFile(@"Images\" + Datas[i, 2] + ".jpg");
                    }
                    else
                    {
                        PictureBox1.Image = Image.FromFile(@"Images\nincs.jpg");
                    }
                }
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
