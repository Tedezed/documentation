using System;

namespace motor

{
	interface IMotor
	{
		// declaración de propiedades
		int Potencia
		{
	      		get;
	      		set;
	 	}
		int Par
	  	{
	      		get;
	      		set;
	   	}

		// declaración de métodos
		void printInfo();
		// declaración de eventos
	}

	public class Motor : IMotor
	{
		int potencia;
		int par;
		public int Potencia {
			get { return this.potencia; }
			set { potencia = value;	}
		}
		public int Par {
			get { return this.par; }
			set { par = value; }
		}
		public void printInfo()
		{
			Console.WriteLine("La potencia es " + Potencia.ToString() + " y el par: " + Par.ToString());
		}
	}

	class MainClass
    {
    	public static void Main (string[] args)
		{
			Motor motor1 = new Motor();
			motor1.printInfo();
		}
	}
}
