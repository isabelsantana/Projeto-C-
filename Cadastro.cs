class Cadastro{
  private string nomes;
  private string nomeCientifico;
  private string habitatNatural;
  private string ordem;
  private string classe;
  private int peso;
  private string reproduçao;
  private int expectativa_de_vida;

  public string getNomes(){
    return nomes;
  }

  public string getNomeCientifico(){
    return nomeCientifico;
  }

  public string getHabitatNatural(){
    return habitatNatural;
  }

  public string getOrdem(){
    return ordem;
  }

  public string getClasse(){
    return classe;
  }
  
  public int getPeso(){
    return peso;
  }

  public string getReproduçao(){
    return reproduçao;
  }

   public int getExpectativadeVida(){
    return expectativa_de_vida;
  }
  
  public void setPeso(int p){
    peso = p;
  }

  public void setExpectativadeVida(int edv){
    expectativa_de_vida = edv;
  }

  public Cadastro(int p, int edv){
    peso = p;
    expectativa_de_vida = edv;
  }
  
  public string[] getNomeAnimais(){
    string[] nomes = new string[] {"Leão", "Hipopótamo", "Lobo Guará", "Cacatua", "Papagaio", "Guepardo", "Coala", "Mico leão dourado", "Crocodilo"};
    return nomes;
  }

  public string[] getNomeCientificoAnimais(){
    string[] nomeCientifico = new string[] {"Hippopotamus amphibius", "Panthera leo", "Chysocyon brachyurus", "Cacatuidae", "Amazona", "Acinonyx jubatus", "Phascolarctos cinereus", "Leontopithecus rosalia", "Crocodylidae"};
    return nomeCientifico;
  }

  public string[] getHabitatNaturalAnimais(){
    string[] habitatNatural = new string[] {"rios e lagoas grandes e profundas com áreas adjacentes para pastagem em quase todos os países da África e na Palestina.", "Era um animal difundido por várias partes do planeta, mas a caça o extinguiu em muitas regiões e hoje o encontramos apenas na África subsaariana e na Ásia. ", "Geralmente é visto de cima, habita em campos abertos, com vegetação de arbustos e áreas de bosque com o dossel aberto.", " As cacatuas têm distribuição geográfica restrita à Oceania (mais precisamente nas florestas australianas) e em ilhas vizinhas do Pacífico.", "Floresta úmida ou seca, bosques de palmeiras ou margens de rios.", "Savanas, planícies arborizadas e zonas semidesérticas.", "Florestas de eucalipto.", "Floresta tropical húmida atlântica.", " Rios, lagos, pântanos e zonas costeiras."};
    return habitatNatural;
  }

  public string[] getOrdemAnimais(){
    string[]  ordem = new string[] {" Artiodáctilos.", "Carnívoros.", "Carnívoros", " Psitaciformes", " Psitaciformes", "Carnívoros", "Diprotodontia", "Primates", "Crocodylia"};
    return ordem;
  }

  public string[] getClasseAnimais(){
    string[] classe = new string[] {"mamíferos ","mamíferos", "mamíferos ", "Aves", "Aves", "mamíferos", "mamíferos", "mamíferos", "Répteis"};
    return classe;
  }

  public int[] getPesoAnimais(){
    int[] peso =  new int[] { 0 };
    /*
    int[] peso = new int[] {"3 a 4 toneladas.", " o macho pesa em torno de 180kg, mas existem registros de animais com 27kg. A fêmea pesa em torno de 120kg mas pode chegar a 180kg.", "20 a 30kg", "entre 500g e 900g", "240g", "35 – 43kg", "4 – 15 kg", " 800g", "1 t"};*/
    return peso;
  }
  
  public string[] getReproduçaoAnimais(){
    string[] reproduçao = new string[] {" A maturidade sexual em cativeiro é atingida entre 3 e 4 anos. Já na vida selvagem os machos não conseguem se acasalar antes dos 6 a 13 anos e as fêmeas entre 7 e 15 anos.", "Os machos alfas copulam com as fêmeas do bando, numa média de 2,2 vezes por hora no período de estro. As fêmeas podem entrar no cio em qualquer época do ano, com picos na estação chuvosa. Normalmente se reproduzem a cada dois anos. Elas atingem a maturidade sexual aos quatro anos de idade e os machos aos cinco.", "O lobo guará é sozinho, diferente de outros lobos ele não vive em alcateia, mas durante o período de reprodução fica junto a sua companheira. Se reproduzem uma vez por ano e a gestação dura em média 65 dias.", "se reproduzem com 4 ou 5 anos, geralmente a fêmea bota de 2 a 5 ovos e os incubam por cerca de 1 mês.", "Atingem maturidade sexual entre dois e três anos. Botam três ou mais ovos, que eclodem em aproximadamente um mês.", "A fêmea é poliéstrica, está recetiva em intervalos curtos de tempo, várias vezes por ano. Por ninhada, nascem em média 4 crias que são amamentadas durante cerca de 4 meses.", "Na época de reprodução, os machos lutam entre si para manterem um pequeno harém de fêmeas reprodutoras.", " A fêmea dominante inibe a atividade reprodutora das fêmeas subordinadas. Existe cooperação de todos os elementos do grupo nos cuidados com as crias, sendo o transporte dos juvenis, tarefa habitual do macho.", "No ritual de acasalamento o macho esfrega a garganta no pescoço da fêmea e segrega um cheiro que a estimula. A cópula ocorre dentro de água. A fêmea constrói o ninho com lama e vegetação e exibe cuidados parentais, guardando os ovos do ninho."};
    return reproduçao;
  }
  
  public int[] getExpectativadeVidaAnimais(){
    int[] expectativa_de_vida = new int[] { 0 };
    /*
    int[] expectativa_de_vida = new int[] {"Podem viver até os 41 anos livres e 54 anos em cativeiro.", "Vivem de 10 a 14 anos na natureza, mas podem chegar aos 20 anos em cativeiro.", "Na natureza, vive cerca de 15 anos", "Cacatua", "Papagaio", "de 40 a 60 anos", "Na natureza mais de 60 anos! Em cativeiro, com uma dieta balanceada, vivem em média 20 anos, sempre com seu característico bom humor. ", "Em cativeiro foi constatado que podem viver até 14,2 anos.", "70 – 100 anos"};*/
    return expectativa_de_vida;
  }

}
