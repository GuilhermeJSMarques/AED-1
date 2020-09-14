using System;

class Pessoa{

private string name;
private int old;
private double weight, height;

public void Mostrar(string n, int o, double w, double h){
  name=n;
  old=o;
  weight=w;
  height=h;

}
public void dados(){
  Console.WriteLine("Nome:{0}, idade:{1}, peso:{2}, altura{3}", name, old, weight, height);  
}
public void Envelhecer(int agora){
  if (((agora - old) > 0) && (old < 21)){
    for (int i = agora - old; i>0; i--){
      Crescer(0.005);
    }
  }
  if (old < agora){
    old = agora;
  }
  Console.WriteLine("Idade agora : {0}", agora);
}
public void Engordar(double engordou){

  if(engordou >= weight){
    Console.WriteLine("Engordou : {0}KG", engordou - weight);
    weight = engordou;
    Console.WriteLine("Peso atual : {0}KG", weight);

    weight = engordou;
  }else{
    Console.WriteLine("Não engordou");
  }
}
public void Emagrecer(double emagreceu){
  if(emagreceu < weight){
    Console.WriteLine("Emagreceu : {0}KG", weight - emagreceu);
    weight=emagreceu;
    Console.WriteLine("Peso atual : {0}KG", weight);
  }else{
    Console.WriteLine("Não emagreceu");
  }
}
public void Crescer(double altura){
  if (altura == 0.005){
    height += altura;
  }else {
    height = altura;

  }

}

}