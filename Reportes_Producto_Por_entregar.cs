using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1programacion
{
    internal class Reportes_Producto_Por_entregar
    {
        private string nitcliente;
        private string codigo_producto;
        private string nombre_producto;
        private Boolean estado_producto;

        public string Nitcliente { get => nitcliente; set => nitcliente = value; }
        public string Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public bool Estado_producto { get => estado_producto; set => estado_producto = value; }
    }
}
