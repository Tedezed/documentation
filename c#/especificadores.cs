using System;

namespace demo

{
	class MainClass
    {
    	public static void Main (string[] args)
		{
			decimal valor = 16325.62m;
			string especificador;

			// Sin especificador
			Console.WriteLine("Sin el especificador tenemos el valor: " + valor.ToString());
			// Especificador numérico estándar
			especificador = "G";
			Console.WriteLine("Con el especificador: " + especificador + " tenemos el valor: " + valor.ToString(especificador));
			// Muestra: 16325,62
			especificador = "C";
			Console.WriteLine("Con el especificador: " + especificador + " tenemos el valor: " + valor.ToString(especificador));
			// Muestra: 16.325,62€
			especificador = "E04";
			Console.WriteLine("Con el especificador: " + especificador + " tenemos el valor: " + valor.ToString(especificador));
			// Muestra: 1,6326E+004
			especificador = "F";
			Console.WriteLine("Con el especificador: " + especificador + " tenemos el valor: " + valor.ToString(especificador));
			// Muestra: 16325,62
			especificador = "N";
			Console.WriteLine("Con el especificador: " + especificador + " tenemos el valor: " + valor.ToString(especificador));
			// Muestra: 16.325,62
			especificador = "P";
			Console.WriteLine("Con el especificador: " + especificador + " tenemos el valor: " + valor.ToString(especificador));
			// Muestra: 1.632.562,00%

		}
	}
}

