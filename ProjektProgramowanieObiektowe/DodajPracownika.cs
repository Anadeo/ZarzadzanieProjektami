using ProjektProgramowanieObiektowe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjektProgramowanieObiektowe.GlobalData;

namespace ProjektProgramowanieObiektowe
{
    public partial class DodajPracownika : Form
    {
        public DodajPracownika()
        {
            InitializeComponent();
        }

        private void pracownik_anuluj_Click(object sender, EventArgs e)
        {
            Menadzer menadzer = new Menadzer();
            menadzer.Show();
            this.Hide();
        }

        private void imie_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pracownicy pracownik_model = new Pracownicy();
            pracownik_model.Imie = Imie.Text;
            pracownik_model.Nazwisko = Nazwisko.Text;
            pracownik_model.DataZatrudnienia = Data.Value;
            context.Pracownicy.Add(pracownik_model);
            context.SaveChanges();
            MessageBox.Show("Dodano!");
            Menadzer menadzer = new Menadzer();
            menadzer.Show();
            this.Hide();

        }
    }
}
