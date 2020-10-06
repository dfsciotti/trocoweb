using System.Collections.Generic;

namespace WebTroco.Models
{
    public class Troco
    {
        public string Mensagem { get; set; }
        public double VlrCompra { get; set; }
        public double VlrPago { get; set; }
        public double? VlrTroco { get; set; }
        public List<ItemTroco> ItensTroco { get; set; }
    }

}
