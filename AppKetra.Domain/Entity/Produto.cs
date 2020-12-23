using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppKetra.Domain.Entities
{
    [Table("SB1")]
    public class Produto
    {
        
        [Key]
        public int NumProduto { get; set; }

        public string Descricao { get; set; }
    }
}
