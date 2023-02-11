using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class UserData 
{
    public Jugador Player;
    string name;
    int Nivel;
    int id;
    
    public UserData (Jugador Player,int Id,string name){
        this.Player=Player;
        this.name=name;
        Nivel = Player.NeNivel();
        this.id = Id;
    }
    public UserData()
    {
        this.Nivel = 0;
        Player = new Jugador (0);
        this.name="Enty Name";
    }
    public int Nivelne(){
        return this.Nivel;
    }

    public string NamePlayer(){
        return this.name;
    }
    public int Id(){
        return this.id;
    }

}
