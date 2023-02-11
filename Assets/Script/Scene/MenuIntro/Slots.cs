using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slots : MonoBehaviour
{
    
    public int numSlot;
    public InputField Nombre;

    public void Guardar(){
        SaveSystem.SaveData(new Jugador(numSlot), numSlot, Nombre.text);
        PathId.PathIdset(SaveSystem.LoadData(numSlot).Id());
    }
    
    public void borrar(){
        SaveSystem.EraseAllData();
    }



}
