/*
Ejercicio 1
Variables - Escribe un programa que reciba datos de una persona y genera un mensaje, 
usa una variable para cada dato y otra para el mensaje. 
Ej: nombre, apellido, edad, sabe programar, etc.
*/

Console.WriteLine("Escribe tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Escribe tu apellido: ");
string apellido = Console.ReadLine();
Console.WriteLine("Escribe tu edad: ");
string edad = Console.ReadLine();
int strEdad = Convert.ToInt32(edad);
Console.WriteLine("Sabes programar?: ");
string sabeprogramar = Console.ReadLine();


string mensaje = "Hola " + nombre + " " + apellido + " tienes: " + edad + " y " + sabeprogramar + " sabes programar";
Console.WriteLine(mensaje);

/*
Ejercicio 2
Tipos - Usando los tipos de variables más adecuados, describe los objetos siguientes:
Coche: puertas, ruedas, marca, ITV vigente
Mesa: peso, largo, material, color
Nota: puedes escribir estos datos por consola si prefieres verlos.
La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*/

//Coche
int puertas = 4;
int ruedas = 4;
string marca = "Fiat";
bool isITV = true;

//Mesa 
int pesoKg = 10;
double largoMts = 2.5;
string material = "madera";
string color = "Marron";

/*
Ejercicio 3
Operadores - Determina los operadores para verificar las siguientes condiciones:
Un número es mayor o igual a 18
Un char es ‘a’
Se cumplen dos conciones a la vez (ambas verdaderas)
Se cumple una de dos condiciones a la vez (una true y otra false)
*/
int num = 17;
char a = 'a';

Console.WriteLine(num > 17);
Console.WriteLine(a == 'a')