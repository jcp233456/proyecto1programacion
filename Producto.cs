using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1programacion
{
    public class Producto
    {
        string codigo;
        string nombre;
        string marca;
        decimal precio_compra;
        decimal precio_venta;
        decimal cantidad_existente;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public decimal Precio_compra { get => precio_compra; set => precio_compra = value; }
        public decimal Precio_venta { get => precio_venta; set => precio_venta = value; }
        public decimal Cantidad_existente { get => cantidad_existente; set => cantidad_existente = value; }
    }
}
