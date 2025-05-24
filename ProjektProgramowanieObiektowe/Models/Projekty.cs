using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektProgramowanieObiektowe.Models
{
    [Table("projekty")]
    public class Projekty
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("nazwa")]
        public string Nazwa { get; set; }

        [Required]
        [Column("czy_gotowy")]
        public bool Czy_gotowy { get; set; }

        [Required]
        [Column("data_rozpoczecia")]
        public DateTime Data_rozpoczecia { get; set; } = DateTime.Now;

        public List<Przypisania> Przypisania { get; set; } = new List<Przypisania>();
    }
}



