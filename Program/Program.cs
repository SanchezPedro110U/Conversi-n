using System;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convertir de Char a Int
            Console.WriteLine("Tipo de conversión implicito");
            char charCharacter = 'z';
            int aCharacterInt = charCharacter;
            Console.WriteLine($"Conversión del caracter ' {charCharacter}' a un valor entero: {aCharacterInt}");

            //Convertir de Char a Int
            Console.WriteLine("Tipo de conversion implicito");
            char charCharacter1 = '&';
            int CharacterIntU = charCharacter1;
            Console.WriteLine($"Conversión del caracter ' {charCharacter1}' a un valor entero: {CharacterIntU}");

            //Conversión int a double y de int a float

            int numberInt = 78;
            double numberDouble = numberInt;
            float numberFloat = numberInt;
            Console.WriteLine($"No.entero =  {numberInt} => float {numberFloat} => double {numberDouble}");

            //Conversión de int en Char

            int aCharacterInte = 64;
            char a = (char)aCharacterInte;

            Console.WriteLine("Tipo de conversion explicita");

            double ValorInicial = 90.838383d;
            Console.WriteLine($"Conversión del valor (double)'{ValorInicial}' a valor tipo float: {(float)ValorInicial}");
            Console.WriteLine($"Conversión del valor (double)'{ValorInicial}' a valor tipo float: {(long)ValorInicial}");
            Console.WriteLine($"Conversión del valor (double)'{ValorInicial}' a valor tipo float: {(char)ValorInicial}");

            //Aqui añadimos la refencias de la doc

            int myInt = 35;
            double myDouble = 73.432d;
            bool myBool = true;
            char myChar = 'z';

            Console.WriteLine(Convert.ToString(myInt)); //35
            Console.WriteLine(Convert.ToDouble(myInt)); //35
            Console.WriteLine(Convert.ToInt32(myChar)); //122
            Console.WriteLine(Convert.ToString(myBool)); //TRUE
            Console.WriteLine(Convert.ToInt64(myDouble)); //73
            Console.WriteLine(Convert.ToBoolean(1)); //True



            //SUMA
            Console.WriteLine("");
            Console.WriteLine("Suma (+)");
            Console.WriteLine($"10 + 7 + 72 = { 10 + 7 + 72}");
            Console.WriteLine($"7.54d + 3.67d + 38.45d = {7.54d + 3.67d + 38.45d}");
            Console.WriteLine($"Interpolación = {(-36) + 7 + (-72) + 65}");
            Console.WriteLine($"(-36) + 7 + (-72) + 65 = {(-36) + 7 + (-72) + 65}");

            //RESTA
            Console.WriteLine("");
            Console.WriteLine("Resta (+)");
            Console.WriteLine($"10 - 7 - 72 = { 10 - 7 - 72}");
            Console.WriteLine($"7.54d - 3.67d - 38.45d = {7.54d - 3.67d - 38.45d}");
            Console.WriteLine($"Interpolación = {(-36) - 7 - (-72) - 65}");
            Console.WriteLine($"(-36) - 7 - (-72) - 65 = {(-36) - 7 - (-72) - 65}");


        }
    }
}
