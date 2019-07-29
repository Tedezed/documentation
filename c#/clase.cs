using System;

namespace persona
{
	public class persona
	{
		// atributos
		string nombre;
		int edad;

		// propiedades: métodos para manejar los atributos
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}

		public int Edad {
			get { return edad; }
			set { edad = value; }
		}

		// Constructor!!!!
		public persona (string _nombre, int _edad)
		{
			// usamos los métodos para manejar atributos en lugar de this.nombre
			Nombre = _nombre;
			Edad = _edad;
		}

		// método para imprimir datos de la instancia
		public void print ()
		{
			System.Console.WriteLine("Nombre: " + nombre + " - Edad: " + edad.ToString());
		}
	}

	class MainClass
    {
    	public static void Main (string[] args)
		{
			persona persona1 = new persona("Pepe", 20);
			persona1.print();
		}
	}
}
