using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_6_MatíasBustos
{
    [Serializable]
    class Bloque : Division
    {
        public Bloque(string nombre, List<Persona> personas, string sector) : base(nombre, personas, sector)
        {
        }
    }
}
