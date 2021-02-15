using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaKolekcije
{
    public partial class Form1 : Form
    {
        List<List<string>> datas = new List<List<string>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void UnesiButton_Click(object sender, EventArgs e)
        {
            datas.Add(new List<string>() { Podatak1Box.Text, Podatak2Box.Text, Podatak3Box.Text, Podatak4Combo.Text });
            Podatak1Box.Text = "";
            Podatak2Box.Text = "";
            Podatak3Box.Text = "";
            Podatak4Combo.Text = "";
        }

        private void IspisButton_Click(object sender, EventArgs e)
        {
            ispisBox.Text = "Podatak1\t\tPodatak2\t\tPodatak3\t\tPodatak4\t\tDodatak\r\n";
            foreach (var data in datas)
            {
                foreach (string text in data)
                {
                    ispisBox.Text += $"{text}\t\t";
                }
                ispisBox.Text += "\r\n";
            }
        }

        private void ObradiUnos_Click(object sender, EventArgs e)
        {
            foreach (var data in datas)
            {
                if (data.Count == 4)
                {
                    if (data[3] == "M")
                    {
                        data.Add("Ima Brkove");
                    }
                    else data.Add("Nema Brkove");
                }
            }
        }
    }
}
