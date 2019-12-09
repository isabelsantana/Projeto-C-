using System.IO;
using System.Text;

class Usuario{
  private string nome;
  private string idade;
  private string telefone;
  private string cpf;

  public Usuario(string cadastro){  
    string[] linhainformaçoes = cadastro.Split('/');
    nome = linhainformaçoes[0];
    idade = linhainformaçoes[1];
    telefone= linhainformaçoes[2];
    cpf = linhainformaçoes[3];
  }

  public string getNome(){
    return nome;
  }

  public void setNome(string n){
   nome=n;
  }

  public string getIdade(){
    return telefone;
  }

  public string getTelefone(){
    return telefone;
  }

  public string getCpf(){
    return cpf;
  }

  public static int qtdLinhas(){
    FileStream  leiturarqUsuario = new FileStream("Usuario.text",FileMode.Open,FileAccess.Read);
    StreamReader lerinfobasic = new StreamReader(leiturarqUsuario,Encoding.UTF8);

    int cont = 0;
    while(!lerinfobasic.EndOfStream){
      lerinfobasic.ReadLine();
      cont++;
    } 

    lerinfobasic.Close();
    leiturarqUsuario.Close();

    return cont;
  }

  public static void cadastrarUsuario( string dadosusuario){
  
    FileStream arqUsuario = new FileStream("Usuario.text",FileMode.Append,FileAccess.Write);
    StreamWriter informaçoesbasicas= new StreamWriter(arqUsuario, Encoding.UTF7);    
    string infobasic = dadosusuario;
    informaçoesbasicas.WriteLine(infobasic);
    informaçoesbasicas.Close();
    arqUsuario.Close();      
  }

  public static Usuario[] retornaVetorUsuario(){
    FileStream  leituraUsuario = new FileStream("Usuario.text",FileMode.Open,FileAccess.Read);
    StreamReader lerinfUsuario = new StreamReader(leituraUsuario,Encoding.UTF8);   
   
    Usuario [] vetorUso = new Usuario[1000];
    int contador = 0;
    while(!lerinfUsuario.EndOfStream){
      string infUsuario = lerinfUsuario.ReadLine();
      Usuario usuario = new Usuario(infUsuario);
      vetorUso [contador] = usuario;     
      contador++;
      
    }
    
    lerinfUsuario.Close();
    leituraUsuario.Close();

    return vetorUso; 
  }
}
