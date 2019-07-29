/* "Hola mundo" escrito en C++ */
#include "iostream"
using namespace std;

#define PI 3.1416;

int main()
{
	char x = 'a'; // Declaramos y asignamos en la misma línea

    int num; //Declaramos el entero en una línea
    num = 5; //Le asignamos un valor en otra línea

    int num2 = 8; //Asignacion y declaracion al tiempo

    float numero; //Un numero decimal
    numero = 3.5; //Le asignamos un valor al decimal

    float res = numero + num2; //Sumamos dos variables y las asignamos a res
    //3.5 + 8 = 11.5

    res = res + num; //Al valor actual de res le sumamos el valor de num
    //11.5 + 5 = 16.5

    bool valor = false; //Variable booleana
    valor = true; // Pueden ser true o false

    res = res*2; //Duplicamos el valor de res 16.5*2 = 33

    cout << res << endl; //Mostramos el valor de res por pantalla
    cout << "Hola mundo! " << PI ;
    return 0;
}