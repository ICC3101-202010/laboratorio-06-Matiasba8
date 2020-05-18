using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_6_MatíasBustos
{
    [Serializable]
    class Division
    {
        private string Nombre;
        private string SectorName;

        private List<Persona> Personal = new List<Persona>();

       

        public Division(string nombre, List<Persona> personas,string sector)
        {
            Nombre1 = nombre;
            Personal1 = personas;
            SectorName1 = sector;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string SectorName1 { get => SectorName; set => SectorName = value; }
        internal List<Persona> Personal1 { get => Personal; set => Personal = value; }
    }
}
