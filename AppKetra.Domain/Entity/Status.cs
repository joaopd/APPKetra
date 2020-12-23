using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppKetra.Domain.Entities
{
    [Table("SCR")]
    public class Status
    {
        [Key]
        public int Num { get; set; }

        public int NumAprov{ get; set; }

        public int Situac { get; set; }

        public DateTime DtLiberac { get; set; }

    }
}
