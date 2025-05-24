using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektProgramowanieObiektowe.Models
{


    [Table("pracownicy")]
    public class Pracownicy
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("imie")]
        public string Imie { get; set; }

        [Required]
        [Column("nazwisko")]
        public string Nazwisko { get; set; }

        [Required]
        [Column("data_zatrudnienia")]
        public DateTime DataZatrudnienia { get; set; }

        //public List<Przypisania> Przypisania { get; set; } = new List<Przypisania>();

        //public Pracownicy()
        //{
        //    this.DataZatrudnienia = DateTime.Now;
        //}
    }
}
