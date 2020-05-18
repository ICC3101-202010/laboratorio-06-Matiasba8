using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laboratorio_6_MatíasBustos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            List<Empresa> DataCompanyStored = new List<Empresa>();

            List<Persona> EncargadoDepartamento = new List<Persona>();

            List<Persona> EncargadoSeccion = new List<Persona>();

            List<Persona> PersonalBloque1 = new List<Persona>();

            List<Persona> PersonalBloque2 = new List<Persona>();

            List<Division> Divisions = new List<Division>();

            

           



            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("|*|*|*|*| Menu de Empresa |*|*|*|*|\n");
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine("¿Quiere usar un archivo para cargar la información de su empresa?\n");
            Console.WriteLine("Ingrese Si o No para continuar");
            string OptionMenuEmpresa = Console.ReadLine();

            if (OptionMenuEmpresa == "Si" || OptionMenuEmpresa == "si" || OptionMenuEmpresa == "SI")
            {
                try
                {
                    DataCompanyStored = LoadCompanyInfo();

                    foreach (Empresa empresa in DataCompanyStored)
                    {
                        Console.WriteLine(empresa.Nombre1);
                    }

                    Console.WriteLine("La informacion de la empresa ha sido cargada con exito!\n");

                    PrintCompanyInfo(DataCompanyStored);
                }
                catch
                {
                    Console.WriteLine("Error: No existe archivo de tipo empresa.bin.\n");

                    Console.WriteLine("A continuacion ingrese los datos de su empresa.\n");
                    Console.WriteLine("Nombre empresa:\n");
                    string Nombre_Empresa = Console.ReadLine();
                    Console.WriteLine("Rut de la empresa:\n");
                    string Rut = Console.ReadLine();
                    

                    //DEPARTAMENTO
                    Console.WriteLine("Nombre del departamento:\n");
                    string Nombre_Departamento = Console.ReadLine();
                    Console.WriteLine("Nombre encargado del departamento:\n");
                    string Nombre_Encargado_Departamento = Console.ReadLine();
                    Console.WriteLine("Apellido encargado del departamento:\n");
                    string Apellido_Encargado_Departamento = Console.ReadLine();
                    Console.WriteLine("Rut encargador del departamento:\n");
                    string Rut_Encargado_Departamento = Console.ReadLine();

                    Persona persona = new Persona(Nombre_Encargado_Departamento, Apellido_Encargado_Departamento, Rut_Encargado_Departamento, "DepartamentoManager");

                    EncargadoDepartamento.Add(persona);

                    Departamento departamento = new Departamento(Nombre_Departamento, EncargadoDepartamento,"DEPARTAMENTO");

                    Divisions.Add(departamento);

                    //SECCION 

                    Console.WriteLine("Nombre de la Sección:\n");
                    string Nombre_Seccion = Console.ReadLine();
                    Console.WriteLine("Nombre encargado de la Sección:\n");
                    string Nombre_Encargado_Seccion = Console.ReadLine();
                    Console.WriteLine("Apellido encargado de la Sección:\n");
                    string Apellido_Encargado_Seccion = Console.ReadLine();
                    Console.WriteLine("Rut encargado de la Sección:\n");
                    string Rut_Encargado_Seccion = Console.ReadLine();

                    Persona persona1 = new Persona(Nombre_Encargado_Seccion, Apellido_Encargado_Seccion, Rut_Encargado_Seccion, "SeccionManager");

                    EncargadoSeccion.Add(persona1);

                    Seccion seccion = new Seccion(Nombre_Seccion, EncargadoSeccion,"SECCIÓN");

                    Divisions.Add(seccion);
                    //BLOQUE 1

                    Console.WriteLine("Nombre del bloque 1:\n");
                    string Nombre_Bloque1 = Console.ReadLine();

                    Console.WriteLine("Nombre encargado 1 del bloque 1:\n");
                    string Nombre_Encargado1_Bloque1 = Console.ReadLine();
                    Console.WriteLine("Apellido encargado 1 del bloque 1:\n");
                    string Apellido_Encargado1_Bloque1 = Console.ReadLine();
                    Console.WriteLine("Rut encargado 1 del bloque 1:\n");
                    string Rut_Encargado1_Bloque1 = Console.ReadLine();

                    Persona Persona1Bloque1 = new Persona(Nombre_Encargado1_Bloque1, Apellido_Encargado1_Bloque1, Rut_Encargado1_Bloque1, "PersonalBloque1");



                    Console.WriteLine("Nombre encargado 2 del bloque 1:\n");
                    string Nombre_Encargado2_Bloque1 = Console.ReadLine();
                    Console.WriteLine("Apellido encargado 2 del bloque 1:\n");
                    string Apellido_Encargado2_Bloque1 = Console.ReadLine();
                    Console.WriteLine("Rut encargado 2 del bloque 1:\n");
                    string Rut_Encargado2_Bloque1 = Console.ReadLine();

                    Persona Persona2Bloque1 = new Persona(Nombre_Encargado2_Bloque1, Apellido_Encargado2_Bloque1, Rut_Encargado2_Bloque1, "PersonalBloque1");


                    PersonalBloque1.Add(Persona1Bloque1);
                    PersonalBloque1.Add(Persona2Bloque1);

                    Bloque bloque1 = new Bloque(Nombre_Bloque1, PersonalBloque1,"BLOQUE1");

                    Divisions.Add(bloque1);

                    //BLOQUE 2

                    Console.WriteLine("Nombre del bloque 2:\n");
                    string Nombre_Bloque2 = Console.ReadLine();

                    //Encargado 
                    Console.WriteLine("Nombre encargado 1 del bloque 2:\n");
                    string Nombre_Encargado1_Bloque2 = Console.ReadLine();
                    Console.WriteLine("Apellido encargado 1 del bloque 2:\n");
                    string Apellido_Encargado1_Bloque2 = Console.ReadLine();
                    Console.WriteLine("Rut encargado 1 del bloque 2:\n");
                    string Rut_Encargado1_Bloque2 = Console.ReadLine();

                    Persona Persona1Bloque2 = new Persona(Nombre_Encargado1_Bloque2, Apellido_Encargado1_Bloque2, Rut_Encargado1_Bloque2, "PersonalBloque2");


                    Console.WriteLine("Nombre encargado 2 del bloque 2:\n");
                    string Nombre_Encargado2_Bloque2 = Console.ReadLine();
                    Console.WriteLine("Apellido encargado 2 del bloque 2:\n");
                    string Apellido_Encargado2_Bloque2 = Console.ReadLine();
                    Console.WriteLine("Rut encargado 2 del bloque 2:\n");
                    string Rut_Encargado2_Bloque2 = Console.ReadLine();

                    Persona Persona2Bloque2 = new Persona(Nombre_Encargado2_Bloque2, Apellido_Encargado2_Bloque2, Rut_Encargado2_Bloque2, "PersonalBloque2");

                    PersonalBloque2.Add(Persona1Bloque2);
                    PersonalBloque2.Add(Persona2Bloque2);

                    Bloque bloque2 = new Bloque(Nombre_Bloque2, PersonalBloque2,"BLOQUE2");

                    Divisions.Add(bloque2);

                    Empresa empresa = new Empresa(Nombre_Empresa, Rut, Divisions);

                    DataCompanyStored.Add(empresa);

                    Console.WriteLine("Datos guardados con exito!\n");


                    SaveCompanyInfo(DataCompanyStored);
                }
                   


            }
            else if(OptionMenuEmpresa == "No" || OptionMenuEmpresa == "NO" || OptionMenuEmpresa == "no")
            {
                Console.WriteLine("A continuacion ingrese los datos de su empresa.\n");
                Console.WriteLine("Nombre empresa:\n");
                string Nombre_Empresa = Console.ReadLine();
                Console.WriteLine("Rut de la empresa:\n");
                string Rut = Console.ReadLine();


                //DEPARTAMENTO
                Console.WriteLine("Nombre del departamento:\n");
                string Nombre_Departamento = Console.ReadLine();
                Console.WriteLine("Nombre encargado del departamento:\n");
                string Nombre_Encargado_Departamento = Console.ReadLine();
                Console.WriteLine("Apellido encargado del departamento:\n");
                string Apellido_Encargado_Departamento = Console.ReadLine();
                Console.WriteLine("Rut encargador del departamento:\n");
                string Rut_Encargado_Departamento = Console.ReadLine();

                Persona persona = new Persona(Nombre_Encargado_Departamento, Apellido_Encargado_Departamento, Rut_Encargado_Departamento, "DepartamentoManager");

                EncargadoDepartamento.Add(persona);

                Departamento departamento = new Departamento(Nombre_Departamento, EncargadoDepartamento,"DEPARTAMENTO");

                Divisions.Add(departamento);

                //SECCION 

                Console.WriteLine("Nombre de la Sección:\n");
                string Nombre_Seccion = Console.ReadLine();
                Console.WriteLine("Nombre encargado de la Sección:\n");
                string Nombre_Encargado_Seccion = Console.ReadLine();
                Console.WriteLine("Apellido encargado de la Sección:\n");
                string Apellido_Encargado_Seccion = Console.ReadLine();
                Console.WriteLine("Rut encargado de la Sección:\n");
                string Rut_Encargado_Seccion = Console.ReadLine();

                Persona persona1 = new Persona(Nombre_Encargado_Seccion, Apellido_Encargado_Seccion, Rut_Encargado_Seccion, "SeccionManager");

                EncargadoSeccion.Add(persona1);

                Seccion seccion = new Seccion(Nombre_Seccion, EncargadoSeccion,"SECCION");

                Divisions.Add(seccion);
                //BLOQUE 1

                Console.WriteLine("Nombre del bloque 1:\n");
                string Nombre_Bloque1 = Console.ReadLine();

                Console.WriteLine("Nombre encargado 1 del bloque 1:\n");
                string Nombre_Encargado1_Bloque1 = Console.ReadLine();
                Console.WriteLine("Apellido encargado 1 del bloque 1:\n");
                string Apellido_Encargado1_Bloque1 = Console.ReadLine();
                Console.WriteLine("Rut encargado 1 del bloque 1:\n");
                string Rut_Encargado1_Bloque1 = Console.ReadLine();

                Persona Persona1Bloque1 = new Persona(Nombre_Encargado1_Bloque1, Apellido_Encargado1_Bloque1, Rut_Encargado1_Bloque1, "PersonalBloque1");



                Console.WriteLine("Nombre encargado 2 del bloque 1:\n");
                string Nombre_Encargado2_Bloque1 = Console.ReadLine();
                Console.WriteLine("Apellido encargado 2 del bloque 1:\n");
                string Apellido_Encargado2_Bloque1 = Console.ReadLine();
                Console.WriteLine("Rut encargado 2 del bloque 1:\n");
                string Rut_Encargado2_Bloque1 = Console.ReadLine();

                Persona Persona2Bloque1 = new Persona(Nombre_Encargado2_Bloque1, Apellido_Encargado2_Bloque1, Rut_Encargado2_Bloque1, "PersonalBloque1");


                PersonalBloque1.Add(Persona1Bloque1);
                PersonalBloque1.Add(Persona2Bloque1);

                Bloque bloque1 = new Bloque(Nombre_Bloque1, PersonalBloque1,"BLOQUE1");

                Divisions.Add(bloque1);

                //BLOQUE 2

                Console.WriteLine("Nombre del bloque 2:\n");
                string Nombre_Bloque2 = Console.ReadLine();

                //Encargado 
                Console.WriteLine("Nombre encargado 1 del bloque 2:\n");
                string Nombre_Encargado1_Bloque2 = Console.ReadLine();
                Console.WriteLine("Apellido encargado 1 del bloque 2:\n");
                string Apellido_Encargado1_Bloque2 = Console.ReadLine();
                Console.WriteLine("Rut encargado 1 del bloque 2:\n");
                string Rut_Encargado1_Bloque2 = Console.ReadLine();

                Persona Persona1Bloque2 = new Persona(Nombre_Encargado1_Bloque2, Apellido_Encargado1_Bloque2, Rut_Encargado1_Bloque2, "PersonalBloque2");


                Console.WriteLine("Nombre encargado 2 del bloque 2:\n");
                string Nombre_Encargado2_Bloque2 = Console.ReadLine();
                Console.WriteLine("Apellido encargado 2 del bloque 2:\n");
                string Apellido_Encargado2_Bloque2 = Console.ReadLine();
                Console.WriteLine("Rut encargado 2 del bloque 2:\n");
                string Rut_Encargado2_Bloque2 = Console.ReadLine();

                Persona Persona2Bloque2 = new Persona(Nombre_Encargado2_Bloque2, Apellido_Encargado2_Bloque2, Rut_Encargado2_Bloque2, "PersonalBloque2");

                PersonalBloque2.Add(Persona1Bloque2);
                PersonalBloque2.Add(Persona2Bloque2);

                Bloque bloque2 = new Bloque(Nombre_Bloque2, PersonalBloque2,"BLOQUE2");

                Divisions.Add(bloque2);

                Empresa empresa = new Empresa(Nombre_Empresa, Rut, Divisions);

                DataCompanyStored.Add(empresa);

                SaveCompanyInfo(DataCompanyStored);

                Console.WriteLine("Datos guardados con exito!\n");

                

                
            }

        }
        static private void SaveCompanyInfo(List<Empresa> DataCompanyStored)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, DataCompanyStored);
            
            stream.Close();
        }

        static public List<Empresa> LoadCompanyInfo()
        {
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            IFormatter formatter = new BinaryFormatter();

            List<Empresa> DataCompanyStored = (List<Empresa>)formatter.Deserialize(stream);
            
            stream.Close();

            

            return DataCompanyStored;
            

        }
        static public void PrintCompanyInfo(List<Empresa> empresas)
        {

            foreach (Empresa empresa in empresas)
            {
                Console.WriteLine("-------------------------------------------------\n");
                Console.WriteLine("|Nombre Empresa|: " + empresa.Nombre1 + " ,|Rut Empresa|: " + empresa.Rut1+"\n");
                Console.WriteLine("-------------------------------------------------\n");
                empresa.ShowEmpresaDivision();
                Console.WriteLine("\n\n");
            }
        }
    }
}
