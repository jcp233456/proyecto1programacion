using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace proyecto1programacion
{
    internal class PersistenciaFactura
    {
        List<Factura> facturas = new List<Factura>();
        string filefactura = "jsonFactura.txt";
        public List<Factura> leerJson()
        {
            if (File.Exists(filefactura))
            {

                string jsonString = File.ReadAllText(filefactura);
                facturas = JsonConvert.DeserializeObject<List<Factura>>(jsonString);

            }

            return facturas;

        }

        public void GuardarJson(List<Factura> facturas)
        {
            string jsonstring = JsonConvert.SerializeObject(facturas);
            File.WriteAllText(filefactura, jsonstring);

        }
    }
}
