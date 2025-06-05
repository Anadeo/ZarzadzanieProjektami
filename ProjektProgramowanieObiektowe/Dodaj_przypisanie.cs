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
    public partial class Dodaj_przypisanie : Form
    {
        Zarzadzaj_przypisania _zarzadzaj_Przypisania;
        private int id_projektu;
        public Dodaj_przypisanie(int id, string nazwa, Zarzadzaj_przypisania zarzadzaj_Przypisania)
        {
            InitializeComponent();
            label_nazwa_projektu.Text = nazwa;
            this.id_projektu = id;
            _zarzadzaj_Przypisania = zarzadzaj_Przypisania;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBox_id_pracownika.Text, out id))
            {
                bool istnieje = context.Pracownicy.Any(p => p.Id == id);
                if (istnieje)
                {
                    Przypisania nowePrzypisanie = new Przypisania();
                    nowePrzypisanie.id_pracownik = id;
                    nowePrzypisanie.id_projekt = this.id_projektu;
                    nowePrzypisanie.Czy_skonczono_prace = false;
                    nowePrzypisanie.Opis_zadania = textBox_opis_zadania.Text;
                    nowePrzypisanie.Termin_wykonania = dateTimePicker_termin.Value;
                    context.Przypisania.Add(nowePrzypisanie);
                    context.SaveChanges();
                    _zarzadzaj_Przypisania.datagrid_pracownicy_revresh();
                    this.Hide();
                }
                else
                {
                    Label_podaj_id_pracownika.Text = "Pracownik o takim id nie istnieje!";
                }
            }
            else
            {
                Label_podaj_id_pracownika.Text = "Podaj poprawny id pracownika";
            }
        }
    }
}
