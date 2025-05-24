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

namespace ProjektProgramowanieObiektowe
{
    public partial class Menadzer : Form
    {
        public Menadzer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Projekt_Click(object sender, EventArgs e)
        {
            DodajProjekt dodajprojekt = new DodajProjekt();
            dodajprojekt.Show();
            this.Hide();
        }
    }
}
