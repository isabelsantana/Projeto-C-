using System.IO;
using System.Text;

public class Animais
{
  private string nome;
  private string nomeCientifico;
  private string habitatNatural;
  private string alimentaçao;
  private string ordem;
  private string classe;
  private int peso;
  private string reproduçao;
  private int expectativa_de_vida;

  public Animais(string consulta){
    string[] linhas = consulta.Split('/');
    nome = linhas[0];
    nomeCientifico = linhas[1];
    habitatNatural = linhas[2];
    alimentaçao = linhas[3];
    ordem = linhas[4];
    classe = linhas[5];
    peso = int.Parse(linhas[6]);
    reproduçao = linhas[7];
    expectativa_de_vida = int.Parse(linhas[8]);
  }
    
  public string getNome(){
    return this.nome;
  }

  public string getNomeCientifico(){
    return this.nomeCientifico;
  }

  public string getHabitatNatural(){
    return this.habitatNatural;
  }

  public string getAlimentaçao(){
    return this.alimentaçao;
  }

  public string getOrdem(){
    return this.ordem;
  }

  public string getClasse(){
    return this.classe;
  }
  
  public int getPeso(){
    return this.peso;
  }

  public string getReproduçao(){
    return this.reproduçao;
  }

   public int getExpectativadeVida(){
    return this.expectativa_de_vida;
  }
  
  public void setPeso(int p){
    peso = p;
  }

  public void setExpectativadeVida(int edv){
    expectativa_de_vida = edv;
  }

  public static int qtdLinhasAnimais(){
    
    FileStream  leituraAnimais = new FileStream("Animais.text",FileMode.Open,FileAccess.Read);
    StreamReader lerinfobasic = new StreamReader(leituraAnimais,Encoding.UTF8);

    int cont = 0;
    while(!lerinfobasic.EndOfStream){
      lerinfobasic.ReadLine();
      cont++;
    } 

    lerinfobasic.Close();
    leituraAnimais.Close();
    return cont;
  }
    
  public static void cadastrarAnimais( string dadosAnimais){
    FileStream arqAnimais = new FileStream("Animais.text",FileMode.Append,FileAccess.Write);
    StreamWriter informaçoesAnimais = new StreamWriter(arqAnimais, Encoding.UTF7);    
    string infobasicas = dadosAnimais;
    informaçoesAnimais.WriteLine(infobasicas);
    informaçoesAnimais.Close();
    arqAnimais.Close();      
  }

  public static Animais [] vetorAnimais(){
    FileStream  leituraAnimais = new FileStream("Animais.text",FileMode.Open,FileAccess.Read);
    StreamReader lerinfobasica = new StreamReader(leituraAnimais,Encoding.UTF8);

    Animais [] vetorAnimal = new Animais[1000];
    int cont = 0;
    while(!lerinfobasica.EndOfStream){
      string infoAnimais = lerinfobasica.ReadLine();
      Animais animalSelecionado = new Animais(infoAnimais);
      vetorAnimal[cont]=animalSelecionado;      
      cont++;
      
    }

    lerinfobasica.Close();
    leituraAnimais.Close();
    return vetorAnimal; 
  }
}  
