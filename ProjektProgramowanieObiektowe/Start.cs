using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektProgramowanieObiektowe
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Start_Load(object sender, EventArgs e)
        {
            // Tu możesz wpisać kod, który ma się wykonać przy starcie
        }

        private void menadzer_click(object sender, EventArgs e)
        {
            Menadzer menadzer = new Menadzer();
            menadzer.Show();
            this.Hide();
        }
        private void pracownik_click(object sender, EventArgs e)
        {
            if (int.TryParse(podaj_id_text.Text, out int id))
            {
                bool istnieje = GlobalData.context.Pracownicy.Any(p => p.Id == id);
                if (istnieje) 
                {
                    Pracownik pracownik = new Pracownik(id);
                    pracownik.Show();
                    this.Hide();
                }
                else
                {
                    podaj_id_label.Text = "Pracownik o takim id nie istnieje!";
                }
            }
            else
            {
                podaj_id_label.Text = "Wprowadź poprawną liczbę";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
