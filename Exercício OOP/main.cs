using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa myperson = new Pessoa();

    myperson.Mostrar("Guilherme",18,60,1.80);
    myperson.dados();

    myperson.Envelhecer(19);
    myperson.Engordar(61);
    myperson.dados();

    myperson.Emagrecer(60);
    myperson.Crescer(1.805);
    myperson.dados();

  }
}