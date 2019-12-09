using System;
using System.IO;
using System.Text;

class Mainclass{
  public static void Main(string[] args) {
    int usuariocadastro = 0, identusuario = 0, numUsuario = 0;
    Console.Clear();
    Console.WriteLine("Digite 1 para fazer seu cadastro ou 2 se já for cadastrado.");
    usuariocadastro = int.Parse(Console.ReadLine());

    Usuario usuarioCadastrado = null;

    if(usuariocadastro == 1){
          Console.WriteLine("Por favor, digite seu nome,idade,telefone e cpf para fazermos seu cadastro.");
          string dadosusuario = Console.ReadLine();
          Usuario.cadastrarUsuario(dadosusuario);
          Console.Clear();
    }
    else{

      if(usuariocadastro == 2){
        Console.WriteLine("Informe seu número de usuário:");
        numUsuario = int.Parse(Console.ReadLine());
        Usuario [] posiçao = Usuario.retornaVetorUsuario();
        usuarioCadastrado = posiçao[numUsuario-1];
        Console.WriteLine("Bem vindo(a) {0} !",usuarioCadastrado.getNome());
        Console.Clear();
      }
      else{
          Console.WriteLine("Opção inválida!");
          Console.Clear();
        }
    } 
    Console.WriteLine("Deseja finalizar o programa? digite sim para sair e não para continuar:");
      string resposta = Console.ReadLine(); 
      if(resposta == "sim"){
        Console.WriteLine("Obrigado por utilizar nosso programa!");
      }
      else{
        if(resposta == "não"){
          Sumario match = new Sumario( cadastradoSumario, Animais.retornaVetoranimais());
       


        }
      }
    
  }

}

