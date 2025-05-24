using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektProgramowanieObiektowe.Models
{
    [Table("przypisania")]
    public class Przypisania
    {
        [Key]
        [Column("id_projekt")]
        public int Id_projekt { get; set; }

        [Required]
        [Column("id_pracownik")]
        public int Id_pracownik { get; set; }

        [Required]
        [Column("opis_zadania")]
        public string Opis_zadania { get; set; }

        [Required]
        [Column("czy_skonczono_prace")]
        public bool Czy_skonczono_prace { get; set; }

        [Required]
        [Column("termin_wykonania")]
        public DateTime Termin_wykonania { get; set; }

        [ForeignKey("id_projekt")]
        public Projekty Projekty { get; set; }

        [ForeignKey("id_pracownik")]
        public Pracownicy Pracownik { get; set; }
    }
}