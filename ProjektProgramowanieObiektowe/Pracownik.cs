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
using ProjektProgramowanieObiektowe.Models;
using ProjektProgramowanieObiektowe.Data;
using Microsoft.EntityFrameworkCore;

namespace ProjektProgramowanieObiektowe
{
    public partial class Pracownik : Form
    {
        private int _idPracownika;
        public Pracownik(int idPracownika)
        {
            InitializeComponent();
            this.Load += wczytywanie;
            this._idPracownika = idPracownika;
        }

        private void wczytywanie(object sender, EventArgs e)
        {
            var wynik = context.Pracownicy
            .Where(prac => prac.Id == _idPracownika)
            .SelectMany(prac => prac.Przypisania)
            .Where(przyp => przyp.Czy_skonczono_prace == false)
            .Select(przyp => new
            {
                id_pracownik = przyp.id_pracownik,
                id_projekt = przyp.id_projekt,
                OpisZadania = przyp.Opis_zadania,
                TerminWykonania = przyp.Termin_wykonania,
                NazwaProjektu = przyp.Projekty.Nazwa
            })
            .ToList();
            dataGridView_d.DataSource = wynik;
            dataGridView_d.Columns["id_pracownik"].Visible = false;
            dataGridView_d.Columns["id_projekt"].Visible = false;

            if (!dataGridView_d.Columns.Contains("btnzmien"))
            {
                var btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "btnzmien";
                btnDelete.HeaderText = "Zmień";
                btnDelete.Text = "Zmień";
                btnDelete.UseColumnTextForButtonValue = true;
                dataGridView_d.Columns.Add(btnDelete);
            }
            //------------
            wynik = context.Pracownicy
            .Where(prac => prac.Id == _idPracownika)
            .SelectMany(prac => prac.Przypisania)
            .Where(przyp => przyp.Czy_skonczono_prace == true)
            .Select(przyp => new
            {
                id_pracownik = przyp.id_pracownik,
                id_projekt = przyp.id_projekt,
                OpisZadania = przyp.Opis_zadania,
                TerminWykonania = przyp.Termin_wykonania,
                NazwaProjektu = przyp.Projekty.Nazwa
            })
            .ToList();
            dataGridView_u.DataSource = wynik;
            dataGridView_u.Columns["id_pracownik"].Visible = false;
            dataGridView_u.Columns["id_projekt"].Visible = false;
            if (!dataGridView_u.Columns.Contains("btnzmien"))
            {
                var btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "btnzmien";
                btnDelete.HeaderText = "Zmień";
                btnDelete.Text = "Zmień";
                btnDelete.UseColumnTextForButtonValue = true;
                dataGridView_u.Columns.Add(btnDelete);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_u_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView_u.Columns["btnzmien"].Index)
            {
                int idPracownika = (int)dataGridView_u.Rows[e.RowIndex].Cells["id_pracownik"].Value;
                int idProjekt = (int)dataGridView_u.Rows[e.RowIndex].Cells["id_projekt"].Value;

                // Znajdź przypisanie według obu kluczy
                var przypisanie = context.Przypisania
                    .FirstOrDefault(p => p.id_pracownik == idPracownika && p.id_projekt == idProjekt);

                if (przypisanie != null)
                {
                    przypisanie.Czy_skonczono_prace = false;
                    context.SaveChanges();

                    // Możesz odświeżyć datagrid, jeśli potrzebujesz
                    odswiez();
                }
            }
        }

        private void dataGridView_d_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView_d.Columns["btnzmien"].Index)
            {
                int idPracownika = (int)dataGridView_d.Rows[e.RowIndex].Cells["id_pracownik"].Value;
                int idProjekt = (int)dataGridView_d.Rows[e.RowIndex].Cells["id_projekt"].Value;

                // Znajdź przypisanie według obu kluczy
                var przypisanie = context.Przypisania
                    .FirstOrDefault(p => p.id_pracownik == idPracownika && p.id_projekt == idProjekt);

                if (przypisanie != null)
                {
                    przypisanie.Czy_skonczono_prace = true;
                    context.SaveChanges();

                    // Możesz odświeżyć datagrid, jeśli potrzebujesz
                    odswiez();
                }
            }
        }
        private void odswiez()
        {
            var wynik = context.Pracownicy
            .Where(prac => prac.Id == _idPracownika)
            .SelectMany(prac => prac.Przypisania)
            .Where(przyp => przyp.Czy_skonczono_prace == false)
            .Select(przyp => new
            {
                id_pracownik = przyp.id_pracownik,
                id_projekt = przyp.id_projekt,
                OpisZadania = przyp.Opis_zadania,
                TerminWykonania = przyp.Termin_wykonania,
                NazwaProjektu = przyp.Projekty.Nazwa
            })
            .ToList();
            dataGridView_d.DataSource = wynik;
            dataGridView_d.Columns["id_pracownik"].Visible = false;
            dataGridView_d.Columns["id_projekt"].Visible = false;

            if (!dataGridView_d.Columns.Contains("btnzmien"))
            {
                var btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "btnzmien";
                btnDelete.HeaderText = "Zmień";
                btnDelete.Text = "Zmień";
                btnDelete.UseColumnTextForButtonValue = true;
                dataGridView_d.Columns.Add(btnDelete);
            }
            //------------
            wynik = context.Pracownicy
            .Where(prac => prac.Id == _idPracownika)
            .SelectMany(prac => prac.Przypisania)
            .Where(przyp => przyp.Czy_skonczono_prace == true)
            .Select(przyp => new
            {
                id_pracownik = przyp.id_pracownik,
                id_projekt = przyp.id_projekt,
                OpisZadania = przyp.Opis_zadania,
                TerminWykonania = przyp.Termin_wykonania,
                NazwaProjektu = przyp.Projekty.Nazwa
            })
            .ToList();
            dataGridView_u.DataSource = wynik;
            dataGridView_u.Columns["id_pracownik"].Visible = false;
            dataGridView_u.Columns["id_projekt"].Visible = false;
            if (!dataGridView_u.Columns.Contains("btnzmien"))
            {
                var btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "btnzmien";
                btnDelete.HeaderText = "Zmień";
                btnDelete.Text = "Zmień";
                btnDelete.UseColumnTextForButtonValue = true;
                dataGridView_u.Columns.Add(btnDelete);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Close();
        }
    }
}
