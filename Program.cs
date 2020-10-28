using System;

namespace URI_1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());
            int valor4 = int.Parse(Console.ReadLine());
            int valor5 = int.Parse(Console.ReadLine());
            
            int valoresPares = 0;
            int valoresImpares = 0;
            int valoresPositivos = 0;
            int valoresNegativos = 0;

            if (valor1 % 2 == 0){
                valoresPares ++;
            }
            else {
                valoresImpares ++;
            }
            if (valor2 % 2 == 0){
                valoresPares ++;
            }
            else {
                valoresImpares ++;
            }
            if (valor3 % 2 == 0){
                valoresPares ++;
            }
            else {
                valoresImpares ++;
            }
            if (valor4 % 2 == 0){
                valoresPares ++;
            }
            else {
                valoresImpares ++;
            }
            if (valor5 % 2 == 0){
                valoresPares ++;
            }
            else {
                valoresImpares ++;
            }
            if (valor1 > 0){
                valoresPositivos ++;
            }
            else {
                valoresNegativos ++;
            }
            if (valor2 > 0){
                valoresPositivos ++;
            }
            else {
                valoresNegativos ++;
            }
            if (valor3 > 0){
                valoresPositivos ++;
            }
            else {
                valoresNegativos ++;
            }
            if (valor4 > 0){
                valoresPositivos ++;
            }
            else {
                valoresNegativos ++;
            }
            if (valor5 > 0){
                valoresPositivos ++;
            }
            else {
                valoresNegativos ++;
            }
            Console.WriteLine(valoresPares + " valor(es) par(es)");
            Console.WriteLine(valoresImpares + " valor(es) impar(es)");
            Console.WriteLine(valoresPositivos + " valor(es) positivo(s)");
            Console.WriteLine(valoresNegativos + " valor(es) negativo(s)");
            
        }
    }
}
