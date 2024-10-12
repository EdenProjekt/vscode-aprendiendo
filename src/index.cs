using System;

namespace PSeInt {
	class hola_mundo {

		static void Main(string[] args) {
			string apellidodeusuario;
			int edad;
			string nombredeusuario;
			Console.WriteLine("Bienvenido");
			Console.WriteLine("Ingresa tu nombre");
			nombredeusuario = Console.ReadLine();
			Console.WriteLine("Ingresa tu Apellido");
			apellidodeusuario = Console.ReadLine();
			Console.WriteLine("Ingresa tu Edad");
			edad = int.Parse(Console.ReadLine());
			Console.WriteLine("Tu nombre es "+nombredeusuario+" "+apellidodeusuario);
			Console.WriteLine("Tienes "+edad+" Años");
		}

	}

}

