using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador 
{
    int Puntos;
    int Intentos;
    int Nivel {get;set;}
    public Jugador (int Puntos, int Intentos, int Nivel){
        this.Puntos=Puntos;
        this.Intentos=Intentos;
        this.Nivel=Nivel;
    }
    public Jugador (){
        this.Puntos=0;
        this.Intentos=0;
        this.Nivel=1;
    }
     
    public int NeNivel(){
        return Nivel;
    }
    
}
