using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Jugador 
{
    
    public int Intentos;
    int Id;
    int Nivel {get;set;}
    public Jugador (int Intentos, int Nivel, int Id){
        
        this.Intentos=Intentos;
        this.Nivel=Nivel;
        this.Id=Id;
    }
    public Jugador (int ID){
        
        this.Intentos=0;
        this.Nivel=1;
        this.Id=ID;
    }
     
    public int NeNivel(){
        return Nivel;
    }
    public int ID(){
        return Id;
    }
    
}
