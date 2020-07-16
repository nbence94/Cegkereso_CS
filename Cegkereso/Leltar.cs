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
    public partial class Leltar : Form
    {
        public int hossz = 0;
        public string[,] Datas = new string[1000, 4];
        
        public Leltar()
        {
            InitializeComponent();
        }

        private void Leltar_Load(object sender, EventArgs e)
        {
            /*for (int i = 0; i < hossz; i++ )
                ListBox1.Items.Add(Datas[i, 0]);
            */
            SzamBeolvas();
            ZonakBeolvas();
        }

        private void SzamBeolvas()
        {
            string curFile = @"Data\numbers.bqf";
            if (File.Exists(curFile))
            {
                using (FileStream fs = new FileStream(@"Data\numbers.bqf", FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            numCb.Items.Add(sr.ReadLine());
                        }
                        sr.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hiányzik egy fontos fájl! (numbers.bqf)");
            }
        }

        private void ZonakBeolvas()
        {
            string curFile = @"Data\zones.bqf";
            if (File.Exists(curFile))
            {
                using (FileStream fs = new FileStream(@"Data\zones.bqf", FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            zoneCb.Items.Add(sr.ReadLine());
                        }
                        sr.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hiányzik egy fontos fájl! (zones.bqf)");
            }
        }

        private void Felvitel()
        {
            bool mindenOK = true;
            if (cegTb.Text == "" || numCb.Text == "" || zoneCb.Text == "")
            {
                MessageBox.Show("Egy fontos adat nincs megadva!");
            }
            else
            {
                var index = numCb.FindStringExact(numCb.Text);
                if(index < 0)
                {
                    mindenOK = false;
                }

                index = zoneCb.FindStringExact(zoneCb.Text);
                if (index < 0)
                {
                    mindenOK = false;
                }


                if(mindenOK == true)
                {
                string info = egyebTb.Text;
                if(egyebTb.Text == "")
                {
                    info = "-";
                }

                    Datas[hossz, 0] = cegTb.Text;
                    Datas[hossz, 1] = numCb.Text; 
                    Datas[hossz, 2] = zoneCb.Text;
                    Datas[hossz, 3] = info;

                    hossz++;
                    Rendezes();
                    MessageBox.Show("Sikeres felvitel!","Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cegTb.Text = "";
                    numCb.Text = "";
                    zoneCb.Text = "";
                    egyebTb.Text = "";
                }
                else
                {
                    MessageBox.Show("Ilyen zóna vagy szám nincs!\nVálassz a lehetőségekből!","Figyelmeztetés",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Rendezes()
        {
            string[] CsakNevek = new string[1000];
            string[,] Atmeneti = new string[1000, 4];

            for (int i = 0; i < hossz; i++)
            {
                CsakNevek[i] = Datas[i, 0];
            }
            Array.Sort(CsakNevek);
            //ListBox1.Items.Clear();

            int index = 0;
            int plusz = 0;
            for (int i = 0; i < hossz; i++)
            {
                if (CsakNevek[i] == null)
                {
                    plusz++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < hossz + plusz; i++)
            {
                if (CsakNevek[i] != null)
                {
                    Atmeneti[index, 0] = CsakNevek[i];
                    for (int j = 0; j < hossz + plusz; j++)
                    {
                        if (Atmeneti[index, 0] == Datas[j, 0])
                        {
                            Atmeneti[index, 0] = Datas[j, 0];
                            Atmeneti[index, 1] = Datas[j, 1];
                            Atmeneti[index, 2] = Datas[j, 2];
                            Atmeneti[index, 3] = Datas[j, 3];
                        }
                    }
                    index++;
                }
            }

            for(int i = 0; i < hossz; i++)
            {
                Datas[i, 0] = Atmeneti[i, 0];
                Datas[i, 1] = Atmeneti[i, 1];
                Datas[i, 2] = Atmeneti[i, 2];
                Datas[i, 3] = Atmeneti[i, 3];
            }
        }

        private void felvitelBtn_Click(object sender, EventArgs e)
        {
            Felvitel();
        }

        private void Leltar_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText(@"Data\places.bqf", String.Empty);
            using (FileStream fs = new FileStream(@"Data\places.bqf", FileMode.Open, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    for (int i = 0; i < hossz; i++)
                    {
                        sw.WriteLine(Datas[i, 0] + "|" + Datas[i, 1] + "|" + Datas[i, 2] + "|" + Datas[i, 3]);
                    }
                    sw.Close();
                }
                fs.Close();
            }
            Application.Restart();
        }

    }
}
