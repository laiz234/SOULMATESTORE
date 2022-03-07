using System;

class Peca{
  private int id;
  private string estilo;
  private string cor;
  private int idGrupo;
  public Peca(int id, string estilo, string cor, int idGrupo){
    this.id = id;
    this.estilo = estilo;
    this.cor = cor;
    this.idGrupo = idGrupo;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetEstilo(string estilo){
    this.estilo = estilo;
  }
  public void SetCor(string cor){
    this.cor = cor;
  }
  public void SetIdGrupo(int idGrupo) {
    this.idGrupo = idGrupo;
  }
  public int GetId(){
    return id;
  }
  public string GetEstilo(){
    return estilo;
  }
  public string GetCor(){
    return cor;
  }
  public int GetIdGrupo(){
    return idGrupo;
  }
  public override string ToString(){
    return $"{id} - {estilo} - {cor} - {idGrupo}";
  }
}