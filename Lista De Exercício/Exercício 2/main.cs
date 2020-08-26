//2- O cardápio de uma casa de lanches é dado pela tabela abaixo:Código Produto Preço Unitário (R$)
//---------------------------------
//100  Cachorro quente   R$ 1,70
//101   Bauru Simples    R$ 2,30
//102   Bauru com ovo    R$ 2,60
//103   Hamburguer       R$ 2,40
//104   Cheeseburguer    R$ 2,50
//105   Refrigerante     R$ 1,00
//----------------------------------
using System;

class MainClass {
  
  public static void Main () {
  
  Console.WriteLine("100 - Cachorro Quente  R$1,70 ");
  Console.WriteLine("101 - Bauru Simples    R$2,30 ");
  Console.WriteLine("102 - Bauru Com Ovo    R$2,60 ");
  Console.WriteLine("103 - Hamburguer       R$2,40 ");
  Console.WriteLine("104 - Cheeseburguer    R$2,50 ");
  Console.WriteLine("105 - Refrigerante     R$1,00 ");
  
  Console.WriteLine("Insira o código do produto: ");
  int cod = int.Parse(Console.ReadLine());
  
  Console.WriteLine("Informe a quantidade: ");
  int qtd = int.Parse(Console.ReadLine());

  if(cod == 100 ){
    Console.WriteLine("Valor final: R$:{0}", 1.70 * qtd);
  }else if(cod == 101){
    Console.WriteLine("Valor final: R$:{0}", 2.30 * qtd);
  }else if(cod == 102){
    Console.WriteLine("Valor final: R$:{0}", 2.60 * qtd);
  }else if(cod == 103){
    Console.WriteLine("Valor final: R$:{0}", 2.40 * qtd);
  }else if(cod == 104){
    Console.WriteLine("Valor final: R$:{0}", 2.50 * qtd);
  }else if(cod == 105){
    Console.WriteLine("Valor final: R$:{0}", 1.00 * qtd);
  }else{
    Console.WriteLine("Erro!!, Digite novamente");

    }
  }
}