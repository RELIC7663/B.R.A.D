using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Jugador 
{
    int Puntos;
    int Intentos;
    int Id;
    int Nivel {get;set;}
    public Jugador (int Puntos, int Intentos, int Nivel){
        this.Puntos=Puntos;
        this.Intentos=Intentos;
        this.Nivel=Nivel;
    }
    public Jugador (int ID){
        this.Puntos=0;
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
