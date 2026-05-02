using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace proyecto1programacion
{
    internal class PersistenciaCliente
    {
        List<Cliente> clientes = new List<Cliente>();
        string filecliente = "jsonCliente.txt";
        public List<Cliente> leerJson()
        {
            if (File.Exists(filecliente))
            {

                string jsonString = File.ReadAllText(filecliente);
                clientes = JsonConvert.DeserializeObject<List<Cliente>>(jsonString);

            }
            
            return clientes;

        }

        public void GuardarJson(List<Cliente> clientes)
        {
            string jsonstring = JsonConvert.SerializeObject(clientes);
            File.WriteAllText(filecliente, jsonstring);

        }
    }
}
