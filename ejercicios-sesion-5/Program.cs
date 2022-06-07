/*
 
 * Ejercicio 1 - While

Escribe una tabla de multiplicar del 1 al 10 para un 
número entero que recibe por consola. Es decir,
un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10
*/
Console.WriteLine("Escribe un numero para ver su tabla: ");
string? number = Console.ReadLine();
int n = int.Parse(number);
int counter = 0;
while (counter < 10)
{
    counter++;
    Console.WriteLine($"{n} x {counter} = {n * counter}");
}

/*
 * Ejercicio 2 - Do while

Escribe un programa que realice estos pasos:
Reciba al menos un número por consola
Determine si el número es positivo o negativo
Presente un contador para cada tipo (positivo y negativo).
Nota: el cero se puede abordar en una clase adicional ya que 
0 no es ni positivo ni negativo. Tienes completa libertad 
para elegir el formato de la salida.
*/

Console.WriteLine("Escribe un numero mayor o menor a 0");
string? number2 = Console.ReadLine();
int n2 = int.Parse(number2);
int counter2 = 0;
do
{
    if (n2 < 0 && counter2 > -10)
    {
        counter2--;
        Console.WriteLine(counter2);
    }
    else if (n2 > 0 && counter2 < 10)
    {
        counter2++;
        Console.WriteLine(counter2);
    }
    else if (n2 == 0)
    {
        Console.WriteLine($"el numero es 0, debes escribir un numero mayor o menor"); break;
    }
    else break;

} while (counter2 > -10 || counter2 < 10);

/*  Ejercicio 3 - For

Escribe un programa que realice estos pasos:

Reciba 3 datos:

ancho

alto

relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:

Input: 2,2,2, relleno = true

Output:

** **

** **

Input: 3, 4, 1, relleno = false

Output:

***

* * 

* *

***  

*/


// solucion sin finalizar 

Console.WriteLine("Inserte alto: ");
int alto = int.Parse(Console.ReadLine());

Console.WriteLine("Inserte largo: ");
int largo = int.Parse(Console.ReadLine());


Console.WriteLine("Inserte 1 para dibujar sin relleno, 2 para dibujar con relleno: ");
int relleno = int.Parse(Console.ReadLine());


string dibujo = "";

for (int i = 0; i < largo; i++) { dibujo += "* "; }

for (int j = 1; j <= alto; j++) { Console.WriteLine(dibujo); }
