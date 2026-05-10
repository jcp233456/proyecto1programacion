using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1programacion
{
    public class Factura
    {
        int numfactura;
        string nitcliente;
        DateTime fechaventa;
        Boolean estadoentrega;
        string codigoproducto;
        string nombreproducto;
        string cantidadproducto;

        public int Numfactura { get => numfactura; set => numfactura = value; }
        public string Nitcliente { get => nitcliente; set => nitcliente = value; }
        public DateTime Fechaventa { get => fechaventa; set => fechaventa = value; }
        public bool Estadoentrega { get => estadoentrega; set => estadoentrega = value; }
        public string Nombreproducto { get => nombreproducto; set => nombreproducto = value; }
        public string Cantidadproducto { get => cantidadproducto; set => cantidadproducto = value; }
        public string Codigoproducto { get => codigoproducto; set => codigoproducto = value; }
    }
}
