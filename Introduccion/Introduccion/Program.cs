using System;

namespace Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            // TIPOS DE DATOS SIMPLES:

            // SOLO NUMEROS
            byte numero = 255;
            sbyte numeroNegativo = -128;
            uint mayorCapacidadSoloPositivos = 4287000000;
            int mayorCapacidadNegativos = -2147000000;
            ulong enteroMasLargo = 111111111111111;
            long enteroMasLargoNegativos = -111111111111111;

            // FLOTANTES
            float flotante = 189.1f;
            double doble = 189.1d;
            decimal masAlcance = 189.1m;

            // CARACTERES
            char caracter = 'A';

            // BOOL
            bool siONo = false;

            // TIPOS DE DATOS COMPUESTOS:

            // STRING
            string cadena = "cadena de caracteres";

            // FECHA (OBJETO)
            DateTime date = DateTime.Now;

            // ----------------------------------------

            // VALORES POR DEFECTO
            int numeroDefecto = new int();
            Console.WriteLine(numeroDefecto.ToString()); // = 0


            // PARA HACER UN OBJETO NULLABLE
            int? numeroNullable = null;
            float? floatNullable = null;
            char? charNullable = null;
            // funciona con otros tipos nativos

            // ----------------------------------------

            // VAR
            var variableNombre = "Fernando"; // le va a dar valor y tipo automaticamente pero una vez definido no me va a permitir cambiar el tipo
            var variableNombre = 2; // tampoco puede ser un atributo, pero si puede ser permitido en un metodo local

            var limite = 50; // es tipo int

            // OBJECT
            // es la base de todos los elementos de C# .NET
            // object persona = new { 
            var persona = new {
                nombre = "Fernando",
                apellido = "Sayago",
                edad = 28
            };
            Console.WriteLine(persona.nombre);
            Console.WriteLine(persona.edad);
        }
    }
}
