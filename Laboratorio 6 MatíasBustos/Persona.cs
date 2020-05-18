using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_6_MatíasBustos
{
    [Serializable]
    class Persona
    {
        string Nombre;
        string Apellido;
        string Rut;
        string Cargo;

        public Persona(string nombre, string apellido, string rut, string cargo)
        {
            Nombre1 = nombre;
            Apellido1 = apellido;
            Rut1 = rut;
            Cargo1 = cargo;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Rut1 { get => Rut; set => Rut = value; }
        public string Cargo1 { get => Cargo; set => Cargo = value; }
    }
}
