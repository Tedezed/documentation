using System;

namespace demo

{
		public class Motor{
		int potencia;
		decimal par;

		public int Potencia { get { return this.potencia; } set { potencia = value;	} }
		public decimal Par { get { return this.par; } set { par = value; } }
	}

	public class Electrico : Motor{
		int intensidad;
		int potencial;

		public int Intensidad { get { return this.intensidad; } set { intensidad = value; } }
		public int Potencial { get { return this.potencial; } set { potencial = value; } }
	}

	// Herencia de CombustionInterna de Motor
	public class CombustionInterna : Motor{
		int cilindrada;
		int cilindros;

		public int Cilindrada { get { return this.cilindrada; } set { cilindrada = value; } }
		public int Cilindros { get { return this.cilindros; } set { cilindros = value; } }
	}

	class MainClass
    {
    	public static void Main (string[] args)
		{
			Electrico a = new Electrico();
			a.Potencia = 100;
		}
	}
}