using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppKetra.Domain.Entities
{
    [Table("SA2")]
    public class Fornecedor
    {
        [Key]
        public int NumFornece { get; set; }

        public string Nome { get; set; }

    }
}
