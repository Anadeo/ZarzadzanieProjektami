using Microsoft.EntityFrameworkCore;
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
    public partial class Zarzadzaj_przypisania : Form
    {
        private bool isLoading = true;
        private int id_projektu = -1;
        private string nazwa_projektu;
        public Zarzadzaj_przypisania()
        {
            InitializeComponent();
            this.Load += wczytywanie;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView_projekty.Columns[e.ColumnIndex].Name == "Przydziel")
            {
                this.id_projektu = ((Projekty)dataGridView_projekty.Rows[e.RowIndex].DataBoundItem).Id;
                var wynik = context.Projekty
                .Where(p => p.Id == this.id_projektu)
                .SelectMany(p => p.Przypisania)
                .Select(przyp => new
                {
                    IdPracownika = przyp.Pracownik.Id,
                    Imie = przyp.Pracownik.Imie,
                    Nazwisko = przyp.Pracownik.Nazwisko,
                    CzySkonczonoPrace = przyp.Czy_skonczono_prace,
                    OpisZadania = przyp.Opis_zadania,
                    TerminWykonania = przyp.Termin_wykonania
                })
                .ToList();
                dataGridView_pracownicy.DataSource = wynik;
                if (!dataGridView_pracownicy.Columns.Contains("btnDelete"))
                {
                    var btnDelete = new DataGridViewButtonColumn();
                    btnDelete.Name = "btnDelete";
                    btnDelete.HeaderText = "Usuń";
                    btnDelete.Text = "Usuń";
                    btnDelete.UseColumnTextForButtonValue = true;
                    dataGridView_pracownicy.Columns.Add(btnDelete);
                }
                this.nazwa_projektu = context.Projekty.Where(p => p.Id == this.id_projektu).Select(p => p.Nazwa).FirstOrDefault();
            }
        }
        private void wczytywanie(object sender, EventArgs e)
        {
            dataGridView_projekty.DataSource = context.Projekty.ToList();
            isLoading = false;
            dataGridView_pracownicy.AutoGenerateColumns = true;
        }
        private void checkboxChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isLoading) return;
            var projekt = (Projekty)dataGridView_projekty.Rows[e.RowIndex].DataBoundItem;
            var projekt_rekord = context.Projekty.Find(projekt.Id);
            projekt.Czy_gotowy = (bool)dataGridView_projekty.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            context.SaveChanges();
        }
        private void CurrentCellDirtyStateChanged_(object sender, EventArgs e)
        {
            if (dataGridView_projekty.IsCurrentCellDirty)
            {
                // jeśli edytowana jest komórka typu checkbox, zatwierdź zmiany natychmiast
                if (dataGridView_projekty.CurrentCell is DataGridViewCheckBoxCell)
                {
                    dataGridView_projekty.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }
        private void button_dodaj_pracownika_Click(object sender, EventArgs e)
        {
            if (this.id_projektu != -1)
            {
                Dodaj_przypisanie przypisanie = new Dodaj_przypisanie(this.id_projektu, this.nazwa_projektu, this);
                przypisanie.Show();
            }
        }

        private void CellContentClick_pracownicy(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView_pracownicy.Columns["btnDelete"].Index)
            {
                // Pobierz Id pracownika z DataGridView
                int idPracownika = (int)dataGridView_pracownicy.Rows[e.RowIndex].Cells["IdPracownika"].Value;

                var wynik = MessageBox.Show("Czy na pewno chcesz usunąć przypisanie tego pracownika z projektu?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (wynik == DialogResult.Yes)
                {
                    // Znajdź przypisanie dla konkretnego projektu i pracownika
                    var przypisanie = context.Przypisania
                        .FirstOrDefault(p => p.id_projekt == this.id_projektu && p.id_pracownik == idPracownika);

                    if (przypisanie != null)
                    {
                        context.Przypisania.Remove(przypisanie);
                        context.SaveChanges();

                        // Odśwież DataGridView, np. ponownie wczytaj dane
                        datagrid_pracownicy_revresh();
                    }
                }
            }
        }
        public void datagrid_pracownicy_revresh()
        {
            var wynik = context.Projekty
            .Where(p => p.Id == this.id_projektu)
            .SelectMany(p => p.Przypisania)
            .Select(przyp => new
            {
                IdPracownika = przyp.Pracownik.Id,
                Imie = przyp.Pracownik.Imie,
                Nazwisko = przyp.Pracownik.Nazwisko,
                CzySkonczonoPrace = przyp.Czy_skonczono_prace,
                OpisZadania = przyp.Opis_zadania,
                TerminWykonania = przyp.Termin_wykonania
            })
            .ToList();
            dataGridView_pracownicy.DataSource = wynik;
            var btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Usuń";
            btnDelete.Text = "Usuń";
            btnDelete.UseColumnTextForButtonValue = true;
            dataGridView_pracownicy.Columns.Add(btnDelete);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menadzer menadzer = new Menadzer();
            menadzer.Show();
            this.Close();
        }
    }
}
