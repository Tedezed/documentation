using System;

namespace direciones
{

	// Ejemplo 1
	public struct Foo
	{
	    public int x;
	    public int X { get { return x; } set { x = value; } }
	}

	// Ejemplo 2
	public struct direccion{
		public string calle;
		public int numero;
		public char letra;

		public string Calle { get { return calle; } set { calle = value; } }
		
		public int Numero { get { return numero; } set { numero = value; } }

		public char Letra { get { return letra; } set { letra = value; } }
	}

	class MainClass
    {
    	public static void Main (string[] args)
		{
			Foo a;
	        a.x = 10; // Valid

	        //Foo b;
	        //b.X = 10; // Invalid

			direccion personal;
			personal.calle = "Avenida sin nombre";
			personal.numero = 6;
			personal.letra = 'C';

			System.Console.WriteLine("Calle: " + personal.Calle);
			System.Console.WriteLine("Numero: " + personal.Numero);
			System.Console.WriteLine("Letra: " + personal.Letra);
		}
	}
}
