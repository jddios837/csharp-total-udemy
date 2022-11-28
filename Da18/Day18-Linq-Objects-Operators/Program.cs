using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18_Linq_Objects_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio de Aplicación Universidad");
            GestionUniversidad app = new GestionUniversidad();
            
            app.ObtenerEstudianteMasculino();
            app.ObtenerEstudianteFemenino();
            app.OrdernarEstudianteOrdenadoPorEdad();
            app.MostrarEstudianteULA();

            app.MostrarEstudianteByUniversiadaId(1);
            app.CrearCollecionEstudiantesUniveridades();
        }
    }

    class GestionUniversidad
    {
        public List<Universidad> Universidades;
        public List<Estudiante> Estudiantes { get; set; }

        public GestionUniversidad()
        {
            Universidades = new List<Universidad>();
            Estudiantes = new List<Estudiante>();
            
            // Agregar Universidades
            Universidades.Add(new Universidad { Id = 1, Nombre = "ULA"});
            Universidades.Add(new Universidad { Id = 2, Nombre = "UPC"});
            
            // Agregar Estudiantes
            Estudiantes.Add(new Estudiante
            {
                Id = 1, 
                Nombre = "Carla", 
                Genero = "femenino", 
                Edad = 19, 
                UniversidadId = 1
            });
            
            Estudiantes.Add(new Estudiante
            {
                Id = 2, 
                Nombre = "Jose", 
                Genero = "masculino", 
                Edad = 22, 
                UniversidadId = 1
            });
            
            Estudiantes.Add(new Estudiante
            {
                Id = 3, 
                Nombre = "Maria", 
                Genero = "femenino", 
                Edad = 23, 
                UniversidadId = 2
            });
            
            Estudiantes.Add(new Estudiante
            {
                Id = 4, 
                Nombre = "Pedro", 
                Genero = "masculino", 
                Edad = 24, 
                UniversidadId = 2
            });
        }

        public void ObtenerEstudianteMasculino()
        {
            // IEnumerable<Estudiante> estudiantesMasculinos = from e 
            //                                                 in Estudiantes 
            //                                                 where e.Genero == "masculino" 
            //                                                 select e;

            IEnumerable<Estudiante> estudiantesMasculinos = Estudiantes.Where(e => e.Genero == "masculino");
            
            Console.WriteLine("Lista de Estudiantes Masculinos");

            foreach (var e in estudiantesMasculinos)
            {
                e.MostrarEstudiante();
                //Console.WriteLine("El estudiante {0} tiene genero {1}", e.Nombre, e.Genero);
            }
        }

        public void MostrarEstudianteULA()
        {
            IEnumerable<Estudiante> lista = from e in Estudiantes
                                            join u in Universidades 
                                                on e.UniversidadId 
                                            equals u.Id
                                            where u.Nombre == "ULA"
                                            select e;
            Console.WriteLine("Estudiantes de la ULA");
            foreach (var e in lista)
            {
                e.MostrarEstudiante();
            }
        }

        public void MostrarEstudianteByUniversiadaId(int id)
        {
            IEnumerable<Estudiante> list = from e in Estudiantes
                join u in Universidades
                    on e.UniversidadId
                    equals u.Id
                where u.Id == id
                select e;
            Universidad universidad = Universidades.First(u => u.Id == id);
            Console.WriteLine("La universidad seleccionada es: {0}", universidad.Nombre);
            foreach(var e in list)
            {
                e.MostrarEstudiante();
            }
        }
        
        public void ObtenerEstudianteFemenino()
        {
            IEnumerable<Estudiante> estudiantesFemeninos = Estudiantes.Where(e => e.Genero == "femenino");
            
            Console.WriteLine("Lista de Estudiantes Femeninos");

            foreach (var e in estudiantesFemeninos)
            {
                e.MostrarEstudiante();
            }
        }

        public void CrearCollecionEstudiantesUniveridades()
        {
            var list = from estudiante in Estudiantes
                join universidad in Universidades on estudiante.UniversidadId equals universidad.Id
                orderby estudiante.Nombre
                select new { NombreEstudiante = estudiante.Nombre, NombreUniversidad = universidad.Nombre };

            Console.WriteLine("Nueva Colleción: ");
            foreach (var i in list)
            {
                Console.WriteLine("Estudiante {0} de la Universidad {1}", i.NombreEstudiante, i.NombreUniversidad);
            }
        }

        public void OrdernarEstudianteOrdenadoPorEdad()
        {
            var estudiantesOrdenados = Estudiantes.OrderBy(e => e.Edad);
            Console.WriteLine("Mostrar estudiantes ordenados por edad");
            foreach (var e in estudiantesOrdenados)
            {
                e.MostrarEstudiante();
            }
        }
    }

    class Universidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void MostrarUniversidad()
        {
            Console.WriteLine("Universidad {0}, tiene el Id {1}", Nombre, Id);
        }
    }

    class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Genero { get; set; }
        
        public int UniversidadId { get; set; }

        public void MostrarEstudiante()
        {
            Console.WriteLine("Estudiante: {0}, tiene el Id {1}, edad {2}, de genero {3} asiste a universidad {4}", Nombre, Id, Edad, Genero, UniversidadId);
        }
    }
}