using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    int Puntos;
    int Intentos;
    int Nivel {get;set;}
    public Player (int Puntos, int Intentos, int Nivel){
        this.Puntos=Puntos;
        this.Intentos=Intentos;
        this.Nivel=Nivel;
    }
    public Player (){
        this.Puntos=0;
        this.Intentos=0;
        this.Nivel=1;
    }
     
    public int NeNivel(){
        return Nivel;
    }
    

}
