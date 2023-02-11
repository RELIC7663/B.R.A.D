using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuperarId : MonoBehaviour
{
    public int id;

    public void IngresarId(){
        PathId.PathIdset(SaveSystem.LoadData(id).Id());
    }
}
