using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace proyecto1programacion
{
    internal class PersistenciaProducto
    {
        List<Producto> productos = new List<Producto>();
        string fileproducto = "jsonProducto.txt";
        public List<Producto> leerJson()
        {
            if (File.Exists(fileproducto))
            {

                string jsonString = File.ReadAllText(fileproducto);
                productos = JsonConvert.DeserializeObject<List<Producto>>(jsonString);

            }
            return productos;

        }

        public void GuardarJson(List<Producto> productos)
        {
            string jsonstring= JsonConvert.SerializeObject(productos);
            File.WriteAllText(fileproducto, jsonstring);

        }

    }
}
