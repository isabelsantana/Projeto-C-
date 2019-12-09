using System;

class Sumario{
  public class Program{
  
  public static void Main(){

  
      string[] animais = new string[10] { "ANIMAIS","1.Hipopotamo", "2.Leão", "3.Lobo Guará", 
        "4.Cacatua", "5.Papagaio", "6.Guepardo", "7.Coala", "8.Mico Leão Dourado",
        "9.Crocodilo" };

      foreach (string animal in animais){
        Console.WriteLine(animal);
      
      }

      string[] estados = new string[9] {"ESTADOS","1.São Paulo", "2.Belo Horizonte", "3.Brasília", "4.Belém", "5.Bahia", "6.Recife", "7.Santa Catarina","8.Paraná"};

      foreach (string estado in estados){
        Console.WriteLine(estado);
      }
    }
  }
}
