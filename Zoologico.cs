class Zoológico{
  private string nomeEstado;
  private string nomeZoologico;
  //private Animal[] animais_zoo;

  public string getNomeEstado(){
    return nomeEstado;
  }

  public string getNomeZoologico(){
    return nomeZoologico;
  }

  public string[] getEstados(){
    string[] nomeEstado = new string[] {"São Paulo", "Belo Horizonte", "Brasília", "Belém", "Bahia", "Recife", "Santa Catarina","Paraná"};
    return nomeEstado;
  }

  public string[] getZoologicos(){
    string[] nomeZoologico = new string[] {"Zoológico de São Paulo", "Zoológico de Belo Horizonte", "Zoológico de Brasília", "Parque Zoobotânico do Museu Paraense Emílio Goeldi", "Zoológico de Salvador", "Parque Dois Irmãos", "Parque das Aves","Zoo Pomorode"};
    return nomeZoologico;
  }
}


