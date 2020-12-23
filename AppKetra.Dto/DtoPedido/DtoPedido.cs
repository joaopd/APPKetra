using AppKetra.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppKetra.Dto.DtoPedido
{
    class DtoPedido : Pedido
    {
        public int NumPedido { get; set; }

        public Fornecedor NomeFornec { get; set; }

        public int NumFornece { get; set; }

        public float ValTotal { get; set; }

        public DateTime DtEmissao { get; set; }

    }
}
