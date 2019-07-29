using System;

namespace holaMundo

{
	class MainClass
    {
    	public static void Main (string[] args)
		{
			Ejemplo1();
			Ejemplo2();
		}

		// Ejemplo 1
		public static void Ejemplo1 ()
		{
			int a = 0;
			int b = 0;

			Console.WriteLine("Valor de: a = {0}, b = {1} antes de llamar a la función", a, b); 

			probarOut(out a,out b);

			Console.WriteLine("Valor de: a = {0}, b = {1} tras llamar a la función", a, b);
		}

		public static void probarOut(out int a, out int b)
		{
			a = 100;
			b = 200;
		}

		// Ejemplo 2
		public static void Ejemplo2 ()
		{
			int a = 1;
			int b = 2;

			Console.WriteLine("Valor de: a = {0}, b = {1} antes de llamar a la función", a, b); 

			intercambiar(ref a, ref b);

			Console.WriteLine("Valor de: a = {0}, b = {1} tras llamar a la función", a, b);
		}

		public static void intercambiar(ref int a, ref int b)
		{
			int tmp = b;
			b = a;
			a = tmp;
		}
	}
}