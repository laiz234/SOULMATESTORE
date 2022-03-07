using System;

class Program{
  public static void Main() {
    Console.WriteLine("Bem-vindo a SOULMATE STORE");
    Grupo g1 = new Grupo(1, "Grupo1");
    Grupo g2 = new Grupo(2, "Grupo2");
    Grupo g3 = new Grupo(3, "Grupo3");
    Grupo g4 = new Grupo(4, "Grupo4");
    Peca p1 = new Peca(1, "Vestido", "Branco", 1 );
    Peca p2 = new Peca(2, "Blusa", "Vermelho", 2 );
    Peca p3 = new Peca(3, "Shorts", "Azul", 3 );
    Peca p4 = new Peca(4, "Biquíni", "Verde", 4 );
    Console.WriteLine(g1);
    Console.WriteLine(g2);
    Console.WriteLine(g3);
    Console.WriteLine(g4);
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);
    Console.WriteLine(p4);
  }
}