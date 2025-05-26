using System;
using System.Collections.Generic;

class Numeros
{
    static void Main()
    {

        List<int> numero = new List<int>();
        // Irá receber dois números inteiros do usuário e exibir o maior deles ou informar se são iguais.
        Console.WriteLine("Digite dois números inteiros para comparar qual é o maior:");
        // Solicita o primeiro número
        Console.Write("Digite o primeiro número: ");
        int primeiroNumero = int.Parse(Console.ReadLine());
        // Armazena o primeiro número na lista
        numero.Add(primeiroNumero);
        // Solicita o segundo número
        Console.Write("Digite o segundo número: ");
        int segundoNumero = int.Parse(Console.ReadLine());
        // Armazena o segundo número na lista
        numero.Add(segundoNumero);
        // Compara os números e exibe o maior ou informa se são iguais
        if (primeiroNumero > segundoNumero)
        {
            Console.WriteLine($"O maior número é: {primeiroNumero}");
        }
        else if (segundoNumero > primeiroNumero)
        {
            Console.WriteLine($"O maior número é: {segundoNumero}");
        }
        else
        {
            Console.WriteLine("Os números são iguais.");
        }

    }
}