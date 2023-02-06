using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class UserData 
{
    Jugador Player;
    string name;
    int Nivel;
    public UserData (Jugador Player,string name){
        this.Player=Player;
        this.name=name;
        Nivel = Player.NeNivel();
    }
    public UserData()
    {
        this.Nivel = 0;
        Player = new Jugador ();
    }
}
