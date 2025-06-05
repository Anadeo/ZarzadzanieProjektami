using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjektProgramowanieObiektowe.Data;
using ProjektProgramowanieObiektowe.Models;
using static ProjektProgramowanieObiektowe.GlobalData;
namespace ProjektProgramowanieObiektowe
{
    public partial class DodajProjekt : Form
    {
        public DodajProjekt()
        {
            InitializeComponent();
        }

        private void dodaj_projekt_Click(object sender, EventArgs e)
        {
            Projekty projekty = new Projekty();
            projekty.Nazwa = projekt_textbox.Text;
            projekty.Czy_gotowy = false;
            context.Projekty.Add(projekty);
            context.SaveChanges();
            MessageBox.Show("Dodano!");
            Menadzer menadzer = new Menadzer();
            menadzer.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menadzer menadzer = new Menadzer();
            menadzer.Show();
            this.Hide();
        }
    }
}
