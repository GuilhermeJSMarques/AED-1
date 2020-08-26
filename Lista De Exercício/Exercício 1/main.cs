//1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.
using System;

  class MainClass 
  {
    public static void Main (string[] args) 
    {
      Console.WriteLine("Digite o primeiro número: ");
      int n1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Escolha uma operação: ");
      string ope = Console.ReadLine();

      Console.WriteLine("Digite o segundo número: ");
      int n2 = int.Parse(Console.ReadLine());

      int result = 0;

      switch (ope)
      {
        case "*":
          result = n1 * n2;
          break;
        case "/":
          result = n1 / n2;
          break;
        case "+":
          result = n1 + n2;
          break;
        case "-":
          result = n1 - n2;
          break;
        default:
          Console.WriteLine("Algo deu errado");
          break;
      }
      Console.WriteLine("{0} {1} {2} = {3}", n1, ope, n2, result);

      Console.ReadKey();

  }
}