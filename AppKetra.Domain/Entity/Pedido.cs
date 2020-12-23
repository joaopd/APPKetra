using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppKetra.Domain.Entities
{
    [Table("SC7")]
    public class Pedido
    {
        
        [Key]
        public int NumPedido { get; set; }
        
        public int NumProduto { get; set; }

        public int NumFornece { get; set; }

        public float ValTotal { get; set; }

        public DateTime DtEmissao { get; set; }

        public float ValUnit { get; set; }



    }
}
