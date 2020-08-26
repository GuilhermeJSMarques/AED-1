//3- Crie um programa que funcione para uma votação eleitoral. Existem três candidatos:
//33 - José Couve
//25 - Joana Bravo
//10 - Roberto Nove
//0 - Voto branco
//4 - Voto nulo

//Deseja-se saber:
//- O candidato vencedor;
//- O total de votos em branco;
//- O total de votos nulos;
using System;
class MainClass {
  public static void Main (string[] args) {

int quantOP1 = 0;
int quantOP2 = 0;
int quantOP3 = 0;
int quantOP4 = 0;
int quantOP5 = 0;

  bool  votosTerminados = false;
while(!(votosTerminados))
{
   bool votoInvalido = true;
    while(votoInvalido)
    {
        Console.WriteLine("Opções: ");
        Console.WriteLine("33 - José Couve");
        Console.WriteLine("25 - Joana Bravo");
        Console.WriteLine("10 - Roberto Nove");
        Console.WriteLine("0  -  Voto Branco");
        Console.WriteLine("4  -  Voto Nulo");
        Console.WriteLine("-1 -  Sair");

        Console.WriteLine("Digite o seu voto: ");
        int voto = int.Parse(Console.ReadLine());

      
    switch(voto)
    {
        case 33: 
          quantOP1++;
          votoInvalido = false;
          break;
        case 25: 
          quantOP2++; 
          votoInvalido = false;
          break;
        case 10: 
          quantOP3++;
          votoInvalido = false;
          break;
        case 0:
          quantOP4++;
          votoInvalido = false;
          break;
        case 4:
          quantOP5++;
          votoInvalido = false;
          break;
        case -1:
          votosTerminados = true;
          votoInvalido = false;
          break;
        default:
          votoInvalido = true;
          Console.WriteLine("Voto inválido!");
          break;
      }                        
    }
}
  Console.WriteLine("Quantidade de votos brancos: " + quantOP4);
  Console.WriteLine("Quantidade de votos nulos: " + quantOP5);

  int mais = quantOP1;
  string ganhador = "José Couve";
    if (quantOP2 > mais){
      mais = quantOP2;
      ganhador = "Joana Bravo";
    }
    if (quantOP3 > mais){
      mais = quantOP3;
      ganhador = "Roberto Nove";
    }
    Console.WriteLine("O ganhador foi "+ ganhador + " com "+ mais + " votos");
  }
}
  
