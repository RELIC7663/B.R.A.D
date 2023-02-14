using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecuperarId : MonoBehaviour
{
    public int id;

    public void IngresarId(){
        PathId.PathIdset(SaveSystem.LoadData(id).Id());
    }
    public static void ContinuarJuego (){
        Debug.Log(SaveSystem.LoadData(PathId.PathIdget()).Nivelne());
      if (SaveSystem.LoadData(PathId.PathIdget()).Nivelne()==1)
      {
        CambiarScenne.NivelCarga("Nivel 01");
      }else if (SaveSystem.LoadData(PathId.PathIdget()).Nivelne()==2)
      {
        CambiarScenne.NivelCarga("Nivel 02");
      }else if (SaveSystem.LoadData(PathId.PathIdget()).Nivelne()==3)
      {
        CambiarScenne.NivelCarga("Nivel 03");
      }else if (SaveSystem.LoadData(PathId.PathIdget()).Nivelne()==4)
      {
        CambiarScenne.NivelCarga("Nivel 04");
      }else{
        CambiarScenne.NivelCarga("Intro");
      }
    }
    
    
}
