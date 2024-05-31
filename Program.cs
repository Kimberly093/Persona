using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace persona_herencia
{
    // Clase base 'Persona'
    class Persona
    {
        // Variables protegidas para los datos de la persona
        protected string nombre;
        protected string fechaNa;
        protected string edad;

        // Propiedades públicas para acceder a los datos
        public string Nombre { get; set; }
        public string FechaNa { get; set; }
        public string Edad { get; set; }

        // Constructor de la clase 'Persona'
        public Persona(string nombre, string fechaNa, string edad)
        {
            Nombre = nombre;
            FechaNa = fechaNa;
            Edad = edad;
        }

        // Método para mostrar información de la persona
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Fecha de Nacimiento: {FechaNa}");
            Console.WriteLine($"Edad: {Edad}");
        }
    }

    // Clase 'Alumnos' que hereda de 'Persona'
    class Alumnos : Persona
    {
        // Atributos específicos de los alumnos
        protected string matricula;
        protected string carrera;

        // Propiedades públicas para acceder a los atributos específicos de los alumnos
        public string Matricula { get; set; }
        public string Carrera { get; set; }

        // Constructor de la clase 'Alumnos'
        public Alumnos(string nombre, string fechaNa, string edad, string matricula, string carrera)
            : base(nombre, fechaNa, edad)
        {
            Matricula = matricula;
            Carrera = carrera;
        }

        // Método para mostrar información del alumno
        public void MostrarInformacionAlumno()
        {
            MostrarInformacion(); // Llama al método de la clase base
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Carrera: {Carrera}");
        }
    }

    // Clase 'Empleado' que hereda de 'Persona'
    class Empleado : Persona
    {
        // Atributos específicos de los empleados
        protected string dni;
        protected string puesto;
        protected string sueldo;

        // Propiedades públicas para acceder a los atributos específicos de los empleados
        public string Dni { get; set; }
        public string Puesto { get; set; }
        public string Sueldo { get; set; }

        // Constructor de la clase 'Empleado'
        public Empleado(string nombre, string fechaNa, string edad, string dni, string puesto, string sueldo)
            : base(nombre, fechaNa, edad)
        {
            Dni = dni;
            Puesto = puesto;
            Sueldo = sueldo;
        }

        // Método para mostrar información del empleado
        public void MostrarInformacionEmpleado()
        {
            MostrarInformacion(); // Llama al método de la clase base
            Console.WriteLine($"DNI: {Dni}");
            Console.WriteLine($"Puesto: {Puesto}");
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }

    // Clase 'Docente' que hereda de 'Persona'
    class Docente : Persona
    {
        // Atributos específicos de los docentes
        protected string dni;
        protected string puesto;
        protected string sueldo;

        // Propiedades públicas para acceder a los atributos específicos de los docentes
        public string Dni { get; set; }
        public string Puesto { get; set; }
        public string Sueldo { get; set; }

        // Constructor de la clase 'Docente'
        public Docente(string nombre, string fechaNa, string edad, string dni, string puesto, string sueldo)
            : base(nombre, fechaNa, edad)
        {
            Dni = dni;
            Puesto = puesto;
            Sueldo = sueldo;
        }

        // Método para mostrar información del docente
        public void MostrarInformacionDocente()
        {
            MostrarInformacion(); // Llama al método de la clase base
            Console.WriteLine($"DNI: {Dni}");
            Console.WriteLine($"Puesto: {Puesto}");
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }

    // Clase 'Program' que contiene el punto de entrada principal de la aplicación
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Ejemplo de uso
            // Crear un alumno
            Alumnos alumno1 = new Alumnos("Jose", "13/08/2004", "21", "123", "Ingeniería");
            // Mostrar información del alumno
            alumno1.MostrarInformacionAlumno();
        }
    }
}
