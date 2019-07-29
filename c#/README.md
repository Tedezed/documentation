# C#

Need: `sudo apt-get install mono-complete`

Compile: `mcs -out:hola hola.cs`

source.bash
```
function csharp+ () {
	FILE_CSHARP=$1
	BIN_CSHARP=$(echo "$1" | cut -d "." -f1)
	mcs -out:$BIN_CSHARP $FILE_CSHARP
	./$BIN_CSHARP
	rm -f $BIN_CSHARP
}
```

##  Tipos de datos

Tipos de valor
    Tipos simples
        Entero con signo: **sbyte**, **short**, **int**, **long**
        Entero sin signo: **byte**, **ushort**, **uint**, **ulong**
        Caracteres Unicode: **char**
        Punto flotante binario IEEE: **float**, **double**
        Punto flotante decimal de alta precisión: **decimal**
        Booleano: **bool**
    Tipos de enumeración
        Tipos definidos por el usuario con el formato **enum E {...}**
    Tipos de estructura
        Tipos definidos por el usuario con el formato **struct S {...}**
    Tipos de valores que aceptan valores NULL
        Extensiones de todos los demás tipos de valor con un valor **null**

Tipos de referencia
    Tipos de clase
        Clase base definitiva de todos los demás tipos: **object**
        Cadenas Unicode: **string**
        Tipos definidos por el usuario con el formato **class C {...}**
    Tipos de interfaz
        Tipos definidos por el usuario con el formato **interface I {...}**
    Tipos de matriz
        Unidimensional y multidimensional; por ejemplo, **int[]** y **int[,]**
    Tipos delegados
        Tipos definidos por el usuario con el formato **delegate int D(...)**


## Estructura basica
```
using System;

namespace demo

{
	class MainClass
    {
    	public static void Main (string[] args)
		{

		}
	}
}
```

## Funciones

Función basica
```
public static void Ejemplo1 ()
{
}
```

Output de variables:
```
public static void Out(out int a, out int b)
{
	a = 100;
	b = 200;
}
```

References de variables:
```
public static void intercambiar(ref int a, ref int b)
{
	int tmp = b;
	b = a;
	a = tmp;
}
```

## Clases

```
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
```

## Struct

```
public struct Foo
{
    public int x;
    public int X { get { return x; } set { x = value; } }
}

class Program
{
    static void Main(string[] args)
    {
        Foo a;
        a.x = 10; // Valid
    }
}
```