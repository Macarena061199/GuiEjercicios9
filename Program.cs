using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*	Solicite un ingreso al usuario y lo presente en mayúsculas.*/

Console.Write("Por favor ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine($"Hola {nombre.ToUpper()}.");

/*	Solicite un ingreso al usuario y lo presente en minúsculas.*/

Console.Write("Por favor ingrese su apellido: ");
string apellido = Console.ReadLine();

Console.WriteLine($"Hola {nombre.ToLower()} {apellido.ToLower()}.");

/*Reemplace en una cadena ingresada por el usuario todas las vocales 
           acentuadas por vocales sin acento y presente el resultado.*/

/*Primera opción*/
bool flag = false;
do
{
    Console.Write("Por favor ingrese un texto cualquiera: ");
    string ingreso = Console.ReadLine();

    string[] ingresoConAcento = new string[] { "á", "é", "í", "ó", "ú", "Á", "É", "Í", "Ó", "Ú" };
    string[] ingresoSinAcento = new string[] { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

    for (int i = 0; i < 10; i++)
    {
        ingreso = ingreso.Replace(ingresoConAcento[i], ingresoSinAcento[i]);
    }

    Console.WriteLine($"Usted ingreso {ingreso}");
    Console.WriteLine("¿Desea seguir ingresando texto? (S/N)");
    ConsoleKeyInfo respuesta = Console.ReadKey();
    if (respuesta.Key == ConsoleKey.S)
    {
        flag = true;
    }
    else if (respuesta.Key == ConsoleKey.N)
    {
        flag = false;
    }

} while (flag == true); 

