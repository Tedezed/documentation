using System;

namespace demo

{
	class MainClass
    {
		public static void Main (string[] args)
		{
			string nombre;
			string apellidos;

			Console.Write("¿Cuál es tu nombre? ");
		       	nombre = Console.ReadLine();
			Console.Write("¿Cuáles son tus apellidos? ");
		       	apellidos = Console.ReadLine();

		       	Console.WriteLine("Usuario: {0}, {1}", apellidos, nombre);
		}
	}
}
