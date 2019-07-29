using System;

namespace demo

{
	class MainClass
    {
    	public static void Main (string[] args)
		{	
			// Ejemplo 1
			int a = 1;
			int b = 0;

			try{
				int c = a / b; // zona protegida
				Console.Write(c);
			}catch(DivideByZeroException exc){
				Console.Write("Ha intentado dividir desde cero\n"); // código a ejecutar
			}

			// Ejemplo 2: Controlar tipo exepcion
			string cadena = "2a";

			try{
				int valor = int.Parse(cadena);
			}catch(FormatException exc){
				Console.Write("Ha ocurrido una excepción por el formato del fichero. Detalles:\n" + exc.Message);
			}catch(Exception exc){
				Console.Write("Ha ocurrido otro tipo de error. Detalles:\n" + exc.Message);
			}
		}
	}
}
