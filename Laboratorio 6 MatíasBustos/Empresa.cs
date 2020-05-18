using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Laboratorio_6_MatíasBustos
{
    [Serializable]
    class Empresa
    {
        private string Nombre;
        private string Rut;

        private List<Division> Divisions = new List<Division>();

        public Empresa(string nombre, string rut, List<Division> divisions)
        {
            Nombre1 = nombre;
            Rut1 = rut;
            Divisions1 = divisions;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Rut1 { get => Rut; set => Rut = value; }
        internal List<Division> Divisions1 { get => Divisions; set => Divisions = value; }

        public void AddDivisions(Division division)
        {
            Divisions1.Add(division);
        }

        public void ShowEmpresaDivision()
        {
            foreach(Division division in Divisions)
            {
                Console.WriteLine("|Nombre "+division.SectorName1+"|: "+ division.Nombre1+"\n");
                foreach(Persona persona in division.Personal1)
                {
                    
                    Console.WriteLine("|Nombre|: " + persona.Nombre1 + ",|Apellido|: " + persona.Apellido1 + ",|Rut|: " + persona.Rut1 + " ,|" + persona.Cargo1+"|\n");
                }
            }
            
        }
      

    }
}
