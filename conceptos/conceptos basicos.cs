using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // =========================================================
            // 1. Introducción a C#
            // C# es un lenguaje de programación moderno, orientado a objetos,
            // desarrollado por Microsoft como parte de su plataforma .NET.
            // Es ampliamente utilizado para desarrollar aplicaciones de escritorio,
            // web, móviles y juegos.

            // =========================================================
            // 2. Sintaxis Básica

            // 2.1. Variables y Tipos de Datos
            int numeroEntero = 10;
            double numeroDecimal = 20.5;
            char caracter = 'A';
            string texto = "Hola, C#!";
            bool esVerdadero = true;

            Console.WriteLine("Variables y Tipos de Datos:");
            Console.WriteLine($"Entero: {numeroEntero}");
            Console.WriteLine($"Decimal: {numeroDecimal}");
            Console.WriteLine($"Caracter: {caracter}");
            Console.WriteLine($"Texto: {texto}");
            Console.WriteLine($"Booleano: {esVerdadero}");
            Console.WriteLine();

            // 2.2. Operadores
            int a = 5;
            int b = 2;
            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            double division = (double)a / b;
            int modulo = a % b;

            Console.WriteLine("Operadores:");
            Console.WriteLine($"{a} + {b} = {suma}");
            Console.WriteLine($"{a} - {b} = {resta}");
            Console.WriteLine($"{a} * {b} = {multiplicacion}");
            Console.WriteLine($"{a} / {b} = {division}");
            Console.WriteLine($"{a} % {b} = {modulo}");
            Console.WriteLine();

            // 2.3. Estructuras de Control

            // If-Else
            Console.WriteLine("Estructura If-Else:");
            if (a > b)
            {
                Console.WriteLine($"{a} es mayor que {b}");
            }
            else
            {
                Console.WriteLine($"{a} no es mayor que {b}");
            }
            Console.WriteLine();

            // Switch
            Console.WriteLine("Estructura Switch:");
            switch (caracter)
            {
                case 'A':
                    Console.WriteLine("El caracter es A");
                    break;
                case 'B':
                    Console.WriteLine("El caracter es B");
                    break;
                default:
                    Console.WriteLine("Caracter desconocido");
                    break;
            }
            Console.WriteLine();

            // Bucles
            Console.WriteLine("Bucle For:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteración {i}");
            }
            Console.WriteLine();

            Console.WriteLine("Bucle While:");
            int contador = 0;
            while (contador < 3)
            {
                Console.WriteLine($"Contador: {contador}");
                contador++;
            }
            Console.WriteLine();

            // =========================================================
            // 3. Programación Orientada a Objetos (POO)

            // 3.1. Clases y Objetos
            Console.WriteLine("Programación Orientada a Objetos:");
            Persona persona = new Persona("Juan", 30);
            persona.MostrarInformacion();
            Console.WriteLine();

            // 3.2. Herencia
            Empleado empleado = new Empleado("Maria", 28, "Desarrolladora");
            empleado.MostrarInformacion();
            Console.WriteLine();

            // 3.3. Polimorfismo
            MostrarInfo(persona);
            MostrarInfo(empleado);
            Console.WriteLine();

            // 3.4. Encapsulamiento
            Console.WriteLine("Encapsulamiento:");
            persona.Edad = 31; // Usando propiedad para modificar la edad
            persona.MostrarInformacion();
            Console.WriteLine();

            // =========================================================
            // 4. Colecciones y Genéricos

            Console.WriteLine("Colecciones y Genéricos:");
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // Diccionario
            Dictionary<string, int> edades = new Dictionary<string, int>();
            edades.Add("Juan", 30);
            edades.Add("Maria", 28);
            foreach (var kvp in edades)
            {
                Console.WriteLine($"{kvp.Key} tiene {kvp.Value} años");
            }
            Console.WriteLine();

            // =========================================================
            // 5. Delegados y Eventos

            Console.WriteLine("Delegados y Eventos:");
            Calculadora calculadora = new Calculadora();
            calculadora.OnOperacionRealizada += OperacionRealizada;
            calculadora.Sumar(5, 3);
            calculadora.Restar(10, 4);
            Console.WriteLine();

            // =========================================================
            // 6. LINQ

            Console.WriteLine("LINQ:");
            var numerosPares = from num in numeros
                               where num % 2 == 0
                               select num;
            Console.WriteLine("Números Pares:");
            foreach (var num in numerosPares)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // =========================================================
            // 7. Manejo de Excepciones

            Console.WriteLine("Manejo de Excepciones:");
            try
            {
                int resultado = a / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: División por cero.");
            }
            finally
            {
                Console.WriteLine("Operación finalizada.");
            }
            Console.WriteLine();

            // =========================================================
            // 8. Asincronía (async/await)

            Console.WriteLine("Asincronía:");
            Task tarea = RealizarOperacionAsincrona();
            tarea.Wait(); // Espera a que la tarea asíncrona termine
            Console.WriteLine();

            // =========================================================
            // 9. Programación Avanzada

            // 9.1. Expresiones Lambda
            Console.WriteLine("Expresiones Lambda:");
            var cuadrados = numeros.Select(x => x * x);
            foreach (var cuadrado in cuadrados)
            {
                Console.WriteLine(cuadrado);
            }
            Console.WriteLine();

            // 9.2. Reflection
            Console.WriteLine("Reflection:");
            Type tipoPersona = typeof(Persona);
            Console.WriteLine($"Nombre de la clase: {tipoPersona.Name}");
            Console.WriteLine("Propiedades:");
            foreach (var prop in tipoPersona.GetProperties())
            {
                Console.WriteLine(prop.Name);
            }
            Console.WriteLine();

            // 9.3. Programación Concurrente
            Console.WriteLine("Programación Concurrente:");
            Task[] tareas = new Task[3];
            for (int i = 0; i < 3; i++)
            {
                int tareaId = i;
                tareas[i] = Task.Run(() => 
                {
                    Console.WriteLine($"Tarea {tareaId} en ejecución.");
                });
            }
            Task.WaitAll(tareas);
            Console.WriteLine();

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método para mostrar información usando polimorfismo
        static void MostrarInfo(Persona persona)
        {
            persona.MostrarInformacion();
        }

        // Método de ejemplo para manejar eventos
        static void OperacionRealizada(string mensaje)
        {
            Console.WriteLine($"Evento: {mensaje}");
        }

        // Método asíncrono de ejemplo
        static async Task RealizarOperacionAsincrona()
        {
            Console.WriteLine("Iniciando operación asíncrona...");
            await Task.Delay(2000); // Simula una operación que tarda 2 segundos
            Console.WriteLine("Operación asíncrona completada.");
        }
    }

    // Clase básica de Persona
    class Persona
    {
        public string Nombre { get; set; }
        private int edad;

        // Propiedad con encapsulamiento
        public int Edad
        {
            get { return edad; }
            set 
            { 
                if (value >= 0)
                    edad = value; 
            }
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }

    // Clase Empleado que hereda de Persona
    class Empleado : Persona
    {
        public string Puesto { get; set; }

        public Empleado(string nombre, int edad, string puesto)
            : base(nombre, edad)
        {
            Puesto = puesto;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Puesto: {Puesto}");
        }
    }

    // Clase Calculadora para demostrar delegados y eventos
    class Calculadora
    {
        // Definición del delegado
        public delegate void OperacionHandler(string mensaje);

        // Evento basado en el delegado
        public event OperacionHandler OnOperacionRealizada;

        public void Sumar(int a, int b)
        {
            int resultado = a + b;
            OnOperacionRealizada?.Invoke($"Suma: {a} + {b} = {resultado}");
        }

        public void Restar(int a, int b)
        {
            int resultado = a - b;
            OnOperacionRealizada?.Invoke($"Resta: {a} - {b} = {resultado}");
        }
    }
}