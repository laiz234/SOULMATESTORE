using System;

class Grupo{
  private int id;
  private string tamanho;
  public Grupo(int id, string tamanho){
    this.id = id;
    this.tamanho = tamanho;
  }
  public void SetId(int id) {
    this.id = id;
  }
  public void SetTamanho(string tamanho){
    this.tamanho = tamanho;
  }
  public int GetId(){
    return id;
  }
  public string GetTamanho(){
    return tamanho;
  }
  public override string ToString(){
    return $"{id} - {tamanho}";
  }
}