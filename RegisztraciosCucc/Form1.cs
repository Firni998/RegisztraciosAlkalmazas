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

namespace RegisztraciosCucc
{
    public partial class Form1 : Form
    {
        private object saveFileDialog;

        public Form1()
        {
            InitializeComponent();
            Hozzaad_Button();
            Mentes();
            
        }

        public void Megnyitas()
        {
            var eredmeny = Open.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {
                string file_nave = Open.FileName;
                using (var file = File.OpenText(file_nave))
                {
                    string sor = file.ReadLine();
                    string[] bekertadatok = sor.Split(';');
                    string[] hobbi = bekertadatok[bekertadatok.Length - 1].Split(',');
                    NevTextBox.Text = bekertadatok[0];
                    
                }
            }

        }
        public void Hozzaad_Button()
        {

            AddButton.Click += (sender, e) =>
            {
                UjHobbi();
            };

        }

        public void UjHobbi()
        {
            string ad = UjHobbiTextBox.Text;
            HobbiListBox.Items.Add(ad);
        
            
        }

        public void Mentes()
        {
            SaveButton.Click += (sender, e) =>
            {
               AdatokMentese ();
            };
        }
        

        public void AdatokMentese()
        {
            string nem = "Semmi";
            if (FERFI.Checked)
            {
                nem = "Ferfi";
            }
            else
            {
                nem = "no";
            }

            string HobbiText = "";


            for (int i = 0; i < HobbiListBox.Items.Count; i++)
            {
                HobbiText += HobbiListBox.Items[i] + ",";
            }
            
            string Bekert_adatok = "";
            Bekert_adatok += NevTextBox.Text + ";" + DatumTextBox.Text + ";" + FERFI.Checked + ";" + HobbiText;



            var eredmeny = Save.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {
                string file_nev;
                file_nev = Save.FileName;
                using (var file = File.CreateText(file_nev))
                {
                    file.Write(Bekert_adatok);
                }
            }
        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
